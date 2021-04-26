using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public interface IAppRoleService
    {
        Task<AppRole> AddAppUserAsync(AppRoleCreateRequest request);
        Task<AppRole> UpdateAppUserAsync(AppRoleEditRequest request);

        Task DeleteAppRoleAsync(AppRole appRole);

        IEnumerable<AppRole> GetAllAppRoleAsync();

        Task<AppRole> GetAppRoleByIdAsync(Guid id);
    }
}
