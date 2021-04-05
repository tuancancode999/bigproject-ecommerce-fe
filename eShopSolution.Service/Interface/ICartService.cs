using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface ICartService
    {
        Task<Cart> AddCartAsync(CartCreateRequest request);

        Task<Cart> UpdateCartAsync(CartEditRequest request);

        Task DeleteCartAsync(Cart cart);

        IEnumerable<Cart> GetAllCartAsync();

        Task<Cart> GetCartByIdAsync(int id);
    }
}
