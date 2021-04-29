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
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }
        public IActionResult Index()
        {
            return View(_manufacturerService.GetAllManufacturerAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateManufacturer(ManufacturerCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _manufacturerService.AddManufacturerAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới nhà cung cấp  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm  mới nhà cung cấp thất bại thất bại");


            return View(request);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _manufacturerService.GetManufacturerByIdAsync(id);
            if (Data != null)
            {
                await _manufacturerService.DeleteManufacturerAsync(Data);
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

            var Data = await _manufacturerService.GetManufacturerByIdAsync(id);
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

            var Data = await _manufacturerService.GetManufacturerByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, ManufacturerEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _manufacturerService.UpdateManufacturerAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
