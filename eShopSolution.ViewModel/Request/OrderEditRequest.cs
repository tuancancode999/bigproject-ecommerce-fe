using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
   public class OrderEditRequest
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderStatusId { get; set; }
        public decimal TotalMonney { get; set; }
        public DateTime DateOfPurchare { get; set; }
        public Status Status { get; set; }
    }
}
