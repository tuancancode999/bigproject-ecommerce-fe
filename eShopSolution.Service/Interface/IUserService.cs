using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public interface IUserService
    {
        Task Login(UserLoginRequest request);

        Task Register(UserRegisterRequest request);
    }
}
