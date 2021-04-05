using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Repository.Implement
{
    public class AppRoleRepository : Repository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(EShopSolutionDBContext EShopSolutionDBContext) : base(EShopSolutionDBContext)
        {
        }

        public Task<AppRole> GetAppRoleIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

       
    }
}
