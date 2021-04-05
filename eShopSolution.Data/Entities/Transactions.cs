using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
   public  class Transactions
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Payment { get; set; }
        public string PaymentInfo { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public AppUser AppUser { get; set; }
        public Order Order { get; set; }
    }
}
