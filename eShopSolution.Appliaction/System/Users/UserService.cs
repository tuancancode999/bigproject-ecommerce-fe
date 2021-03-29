using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.System;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appliaction.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppUser> _roleManager;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager , RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           
        }

        public async Task<bool> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
