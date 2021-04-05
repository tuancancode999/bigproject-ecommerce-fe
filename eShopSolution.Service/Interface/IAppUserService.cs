using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public  interface IAppUserService
    {
        Task<AppUser> UpdateAppUserAsync(AppUserEditRequest request);

        Task DeleteAppUserAsync(AppUser appUser);

        IEnumerable<AppUser> GetAllAppUserAsync();

        Task<AppUser> GetAppUserByIdAsync(Guid id);
    }
}
