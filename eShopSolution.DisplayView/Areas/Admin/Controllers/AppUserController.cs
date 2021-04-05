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
    public class AppUserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly EShopSolutionDBContext _context;

        public AppUserController(IAppUserService appUserService, EShopSolutionDBContext context)
        {
            _appUserService = appUserService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_appUserService.GetAllAppUserAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {

            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _appUserService.GetAppUserByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {

            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _appUserService.GetAppUserByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, AppUserEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _appUserService.UpdateAppUserAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
