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
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public IActionResult Index()
        {
            return View(_notificationService.GetAllNotificationAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateNotification(NotificationCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _notificationService.AddNotificationAsync(request);
            if (result != null)
            {
                TempData["result"] = "Thêm mới thông báo  thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm  mới thông báo thất bại");


            return View(request);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            if (id == null)
            {
                TempData["result"] = "Notification này không tồn tại";
                return NotFound();
            }

            var Data = await _notificationService.GetNotificationByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, NotificationEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _notificationService.UpdateNotificationAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
