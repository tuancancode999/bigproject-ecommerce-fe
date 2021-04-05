using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface ITransactionService
    {
        Task<Transactions> AddTransactionAsync(TransactionCreateRequest request);

        Task<Transactions> UpdateTransactionAsync(TransactionEditRequest request);

        Task DeleteTransactionAsync(Transactions transactions);

        IEnumerable<Transactions> GetAllTransactionAsync();

        Task<Transactions> GetTransactionByIdAsync(int id);
    }
}
