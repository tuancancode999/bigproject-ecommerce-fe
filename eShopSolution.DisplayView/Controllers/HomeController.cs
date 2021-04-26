using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.DisplayView.Models;
using eShopSolution.ViewModels.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly EShopSolutionDBContext _context;

        public HomeController(EShopSolutionDBContext context)
        {
                _context = context;
        }
            
        public IActionResult Index()
        {
          

            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Menu()
        {
            var list1 = (from b in _context.Products
                         where b.CategoryId == 1
                         select b).Take(4);

            var list2 = (from b in _context.Products
                         where b.CategoryId == 2
                         select b).Take(4);

            var list3 = (from b in _context.Products
                         where b.CategoryId == 3
                         select b).Take(4);

            var list4 = (from b in _context.Products
                         where b.CategoryId == 4
                         select b).Take(4);

            var listAll1 = from b in _context.Products
                         where b.CategoryId == 1
                         select b;

            var listAll2 = from b in _context.Products
                         where b.CategoryId == 2
                         select b;

            var listAll3 = from b in _context.Products
                         where b.CategoryId == 3
                         select b;

            var listAll4 = from b in _context.Products
                           where b.CategoryId == 4
                           select b;

            ViewBag.list1 = list1.ToArray();
            ViewBag.list2 = list2.ToArray();
            ViewBag.list3 = list3.ToArray();
            ViewBag.list4 = list4.ToArray();
            ViewBag.listAll1 = listAll1.ToArray();
            ViewBag.listAll2 = listAll2.ToArray();
            ViewBag.listAll3 = listAll3.ToArray();
            ViewBag.listAll4 = listAll4.ToArray();
            return View();
        }

        public IActionResult ProductDetail(int Id)
        {
            var list = from b in _context.Products
                           where b.Id == Id
                           select b;
            ViewBag.list = list.ToArray();
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetail()
        {
            return View();
        }
    }
}
