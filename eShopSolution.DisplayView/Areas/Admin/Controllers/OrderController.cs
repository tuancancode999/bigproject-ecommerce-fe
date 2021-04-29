using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly EShopSolutionDBContext _context;
        public OrderController(IOrderService orderService, EShopSolutionDBContext context)
        {
            _orderService = orderService;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Data = _context.Orders.Include(r => r.AppUser).Include(r => r.OrderStatus);
            return View(await Data.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> CreateManufacturer(OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _orderService.AddOrderAsync(request);
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
            var Data = await _orderService.GetOrderByIdAsync(id);
            if (Data != null)
            {
                await _orderService.DeleteOrderAsync(Data);
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

            var list = from x in _context.Orders
                       from y in _context.OrderDetails
                       from z in _context.Products
                       from h in _context.OrderStatus
                       where x.Id == y.OrderId && z.Id == y.ProductId && x.OrderStatusId == h.Id && x.Id == id
                       select new { z.NameProduct, z.Cost, h.StatusName, y.Amount , y.Note };
            ViewBag.list = list.ToArray();
            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _orderService.GetOrderByIdAsync(id);
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

            var Data = await _orderService.GetOrderByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, OrderEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _orderService.UpdateOrderAsync(request);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }
    }
}
