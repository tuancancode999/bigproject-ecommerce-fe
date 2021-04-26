using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
   public class OrderStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
