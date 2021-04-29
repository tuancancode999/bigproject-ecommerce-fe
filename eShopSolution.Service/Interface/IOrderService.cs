using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface IOrderService
    {
        Task<Order> AddOrderAsync(OrderCreateRequest request);

        Task<Order> UpdateOrderAsync(OrderEditRequest request);

        Task DeleteOrderAsync(Order order);

        IEnumerable<Order> GetAllOrderAsync();

        Task<Order> GetOrderByIdAsync(int id);
    }
}
