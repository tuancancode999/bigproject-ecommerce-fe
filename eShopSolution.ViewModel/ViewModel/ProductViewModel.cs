using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }   
    }
}
