using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly EShopSolutionDBContext _context;
        public ProductController(IProductService productService, EShopSolutionDBContext context)
        {
            _context = context;
            _productService = productService;
        }

        public IActionResult Index(int? page = 0)
        {
            int limit = 5;
            int start;
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            start = (int)(page - 1) * limit;

            ViewBag.pageCurrent = page;

            int totalProduct = _productService.totalProduct();

            ViewBag.totalProduct = totalProduct;

            ViewBag.numberPage = _productService.numberPage(totalProduct, limit);

            var data = _productService.paginationProduct(start, limit);

            return View(data);

            //return View(_productService.GetAllProductAsync());
        }


        public IActionResult Search(string searchString)
        {
            var Data = _productService.Search(searchString);
            return View(Data);
        }

        public IActionResult Create()
        {
            var listCategory = from x in _context.Categories
                       select  x;
            var listManufacturers = from z in _context.Manufacturers
                               select z;
            ViewBag.listCategory = listCategory.ToArray();
            ViewBag.listManufacturers = listManufacturers.ToArray();
            return View();
        }

        public async Task<IActionResult> CreateProduct(ProductCreateRequest request, IFormFile ful)
        {

            if (!ModelState.IsValid)
                return View(request);

            var result = await _productService.AddProductAsync(request);

            if (result != null)
            {
                TempData["result"] = "Thêm mới sản phẩm  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm mới sản phẩm  thất bại");


            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _productService.GetProductByIdAsync(id);
            if (Data != null)
            {
                await _productService.DeleteProductAsync(Data);
                return RedirectToAction("Index");
            }
            if (Data == null)
            {
                return NotFound();
            }

            return View(Data);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {

            var list = from x in _context.Products
                       from y in _context.Categories
                       from z in _context.Manufacturers
                       where y.Id == x.CategoryId && z.Id == x.ManufacturerId && x.Id == id
                       select new { y.CategoryName, z.ManufactureName , x.Image};
            ViewBag.list = list.ToArray();
            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _productService.GetProductByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var listForeignKey1 = from x in _context.Products
                       from y in _context.Categories
                       where x.CategoryId == y.Id && x.Id == id
                       select y;

            var listForeignKey2 = from x in _context.Products
                       from z in _context.Manufacturers
                       where x.CategoryId == z.Id && x.Id == id
                       select z;

            var listCategory = from x in _context.Categories
                               select x;
            var listManufacturers = from z in _context.Manufacturers
                                    select z;

            ViewBag.listCategory = listCategory.ToArray();
            ViewBag.listManufacturers = listManufacturers.ToArray();
            ViewBag.listForeignKey1 = listForeignKey1.ToArray();
            ViewBag.listForeignKey2 = listForeignKey2.ToArray();
            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _productService.GetProductByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _productService.UpdateProductAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
