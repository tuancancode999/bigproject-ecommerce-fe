using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Repository.Interface
{
   public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<AppUser> GetAppUserIdAsync(Guid id);
    }
}
