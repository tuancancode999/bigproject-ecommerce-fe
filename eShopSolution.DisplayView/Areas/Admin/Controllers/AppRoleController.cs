using eShopSolution.Data.EF;
using eShopSolution.Service.Interface;
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
    public class AppRoleController : Controller
    {
        private readonly IAppRoleService _appRoleService;
        private readonly EShopSolutionDBContext _context;

        public AppRoleController(IAppRoleService appRoleService, EShopSolutionDBContext context)
        {
            _appRoleService = appRoleService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_appRoleService.GetAllAppRoleAsync());
        }
    }
}
