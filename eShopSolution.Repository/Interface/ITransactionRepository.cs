using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Data.Entities;

namespace eShopSolution.Repository.Interface
{
   public interface ITransactionRepository : IRepository<Transactions>
    {
        Task<Transactions> GetTransactionByIdAsync(int id);
    }
}
