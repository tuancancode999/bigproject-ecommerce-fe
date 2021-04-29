using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
    public class GetProductPagingRequest
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public Status Status { get; set; }
    }
}
