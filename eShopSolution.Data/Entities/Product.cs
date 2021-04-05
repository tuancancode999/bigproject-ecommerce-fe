using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Cost { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Image> Images { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<FeatBack> FeatBacks { get; set; }

        public Category Category { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public static implicit operator int(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
