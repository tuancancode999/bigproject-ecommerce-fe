using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
        public OrderService(EShopSolutionDBContext context, IMapper mapper, IOrderRepository orderRepository)
        {
            _context = context;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
        public async Task<Order> AddOrderAsync(OrderCreateRequest request)
        {
            var Order = _mapper.Map<Order>(request);
            return await _orderRepository.AddAsync(Order);
        }

        public Task DeleteOrderAsync(Order order)
        {
            return _orderRepository.DeleteAsync(order);
        } 

        public IEnumerable<Order> GetAllOrderAsync()
        {
            return _orderRepository.GetAll();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);
        }

        public async Task<Order> UpdateOrderAsync(OrderEditRequest request)
        {
            var Order = _mapper.Map<Order>(request);
            return await _orderRepository.UpdateAsync(Order);
        }
    }
}
