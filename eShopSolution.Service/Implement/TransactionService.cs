using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
   public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public TransactionService(ITransactionRepository transactionRepository, EShopSolutionDBContext context, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _context = context;
            _mapper = mapper;
        }
        public Task<Transactions> AddTransactionAsync(TransactionCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTransactionAsync(Transactions transactions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transactions> GetAllTransactionAsync()
        {
            return _transactionRepository.GetAll();
        }

        public async Task<Transactions> GetTransactionByIdAsync(int id)
        {
            return await _transactionRepository.GetTransactionByIdAsync(id);
        }

        public Task<Transactions> UpdateTransactionAsync(TransactionEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
