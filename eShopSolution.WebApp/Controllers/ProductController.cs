using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService )
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAllProductAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productService.AddProductAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }


        [HttpGet]
        public async Task<IActionResult>Delete(int id)
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
        public async Task<IActionResult>Detail(int id)
        {
            if(id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _productService.GetProductByIdAsync(id);
            if( Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
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
        public async Task<IActionResult> EditProduct(int id,ProductEditRequest request)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _productService.GetProductByIdAsync(id);
            if (Data != null)
            {
                await _productService.UpdateProductAsync(request);
                return RedirectToAction("Index");
            }
            if (Data == null)
            {
                return NotFound();
            }

            return View(Data);
        }

    }
}
