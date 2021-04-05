using eShopSolution.Data.Entities;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
  
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserService(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public Task Login(UserLoginRequest request)
        {
            var result = _signInManager.PasswordSignInAsync(request.Email, request.Password, request.RememberMe, false);
            return result;
        }

        public Task Register(UserRegisterRequest request)
        {
            var user = new AppUser
            {
                UserName = request.Email,                  
                Email = request.Email,
            };
            var result =  _userManager.CreateAsync(user, request.Password);
            return result ;
        }

        
    }
}
