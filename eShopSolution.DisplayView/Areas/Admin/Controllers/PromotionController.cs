using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class PromotionController : Controller
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }
        public IActionResult Index()
        {

            return View(_promotionService.GetAllPromotionAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreatePromotion(PromotionCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _promotionService.AddManufacturerAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới khuyến mãi  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm mới khuyến mãi  thất bại");


            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _promotionService.GetPromotionByIdAsync(id);
            if (Data != null)
            {
                await _promotionService.DeletePromotionAsync(Data);
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

            var Data = await _promotionService.GetPromotionByIdAsync(id);
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

            var Data = await _promotionService.GetPromotionByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, PromotionEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _promotionService.UpdatePromotionAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
