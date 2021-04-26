using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Repository.Interface
{
    public interface ISizeRepository : IRepository<Sizes>
    {
        Task<Sizes> GetSizeByIdAsync(int id);
    }
}
