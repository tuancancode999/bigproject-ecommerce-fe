using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class FeatBack
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        
        public AppUser appUser { get; set; }

        public Product Product { get; set; }
    }
}
