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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EShopDBContext eShopDBContext) : base(eShopDBContext)
        {
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }


  
    }
}
