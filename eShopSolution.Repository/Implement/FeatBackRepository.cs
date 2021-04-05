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
    public class FeatBackRepository : Repository<FeatBack>, IFeatBackRepository
    {
        public FeatBackRepository(EShopSolutionDBContext EShopSolutionDBContext) : base(EShopSolutionDBContext)
        {
        }
        public Task<FeatBack> GetFeatBackByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
