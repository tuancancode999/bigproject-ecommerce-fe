using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
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
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly EShopSolutionDBContext _context;
        public TransactionController(ITransactionService transactionService, EShopSolutionDBContext context)
        {
            _transactionService = transactionService ;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Data = _context.Transactions.Include(r => r.AppUser);
            return View(await Data.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {

            var list = from x in _context.Orders
                       from y in _context.OrderDetails
                       from z in _context.Products
                       from h in _context.OrderStatus
                       where x.Id == y.OrderId && z.Id == y.ProductId && x.OrderStatusId == h.Id && x.Id == id
                       select new { z.NameProduct, z.Cost, h.StatusName, y.Amount, y.Note };
            ViewBag.list = list.ToArray();
            if (id == null)
            {
                TempData["result"] = "Sản phẩm này không tồn tại";
                return NotFound();
            }

            var Data = await _transactionService.GetTransactionByIdAsync(id);
            if (Data == null)
            {
                return NotFound();
            }
            return View(Data);
        }

    }
}
