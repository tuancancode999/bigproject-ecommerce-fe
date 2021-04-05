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
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public CartService(EShopSolutionDBContext context, IMapper mapper, ICartRepository cartRepository)
        {
            _context = context;
            _mapper = mapper;
            _cartRepository = cartRepository;
        }

        public async Task<Cart> AddCartAsync(CartCreateRequest request)
        {
            var Cart = _mapper.Map<Cart>(request);
            return await _cartRepository.AddAsync(Cart);
        }

        public Task DeleteCartAsync(Cart cart)
        {
            return _cartRepository.DeleteAsync(cart);
        }

        public IEnumerable<Cart> GetAllCartAsync()
        {
            return _cartRepository.GetAll();
        }

        public async Task<Cart> GetCartByIdAsync(int id)
        {
            return await _cartRepository.GetCartByIdAsync(id);
        }

        public async Task<Cart> UpdateCartAsync(CartEditRequest request)
        {
            var Cart = _mapper.Map<Cart>(request);
            return await _cartRepository.UpdateAsync(Cart);
        }
    }
}
