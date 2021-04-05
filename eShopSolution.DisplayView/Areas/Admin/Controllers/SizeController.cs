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
    public class SizeController : Controller
    {
        private readonly ISizeService _sizeService;

        public SizeController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        public IActionResult Index()
        {

            return View(_sizeService.GetAllSizeAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateSize(SizeCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _sizeService.AddSizeAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới Size  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm mới Size  thất bại");


            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _sizeService.GetSizesByIdAsync(id);
            if (Data != null)
            {
                await _sizeService.DeleteSizeAsync(Data);
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

            var Data = await _sizeService.GetSizesByIdAsync(id);
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

            var Data = await _sizeService.GetSizesByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, SizeEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _sizeService.UpdateSizeAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
