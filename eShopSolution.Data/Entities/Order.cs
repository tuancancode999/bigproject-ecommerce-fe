using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderStatusId { get; set; }
        public int TotalMonney { get; set; }
        public DateTime DateOfPurchare { get; set; }
        public Status Status { get; set; }
      
        public AppUser AppUser{ get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Transactions> Transactions { get; set; }
    }
}
