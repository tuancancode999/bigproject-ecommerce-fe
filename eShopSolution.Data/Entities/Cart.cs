using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }

        public AppUser AppUser { get; set; }

        public Product Product { get; set; }
    }
}
