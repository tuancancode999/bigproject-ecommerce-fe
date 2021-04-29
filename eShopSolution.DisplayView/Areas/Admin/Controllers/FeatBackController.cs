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
    public class FeatBackController : Controller
    {
       
        private readonly IFeatBackService _featBackService;
        private readonly EShopSolutionDBContext _context;

        public FeatBackController(IFeatBackService featBackService, EShopSolutionDBContext context)
        {
            _featBackService = featBackService;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Data = _context.FeatBacks.Include(r => r.appUser).Include(r => r.Product);
            return View(await Data.ToListAsync());
        }
    }
}
