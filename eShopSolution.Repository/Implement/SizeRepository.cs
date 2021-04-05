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
    public class SizeRepository : Repository<Sizes>, ISizeRepository
    {
        protected readonly EShopSolutionDBContext _context;

        public SizeRepository(EShopSolutionDBContext EShopSolutionDBContext) : base(EShopSolutionDBContext)
        {
        }

        public Task<Sizes> GetSizeByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
