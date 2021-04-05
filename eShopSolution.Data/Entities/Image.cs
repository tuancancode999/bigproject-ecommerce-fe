using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NameImage { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public Product Product { get; set; }
    }
}
