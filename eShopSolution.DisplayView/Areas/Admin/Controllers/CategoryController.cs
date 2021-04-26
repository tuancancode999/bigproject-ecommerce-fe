using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly EShopSolutionDBContext _context;

        public CategoryController(ICategoryService categoryService, EShopSolutionDBContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAllCategoryAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> CreateCategory(CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _categoryService.AddCategoryAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới thể loại  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm thể loại thất bại thất bại");


            return View(request);


        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _categoryService.GetCategoryByIdAsync(id);
            if (Data != null)
            {
                await _categoryService.DeleteCategoryAsync(Data);
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
            
            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _categoryService.GetCategoryByIdAsync(id);
            if (Data == null)
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

            var Data = await _categoryService.GetCategoryByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CategoryEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _categoryService.UpdateCategoryAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
