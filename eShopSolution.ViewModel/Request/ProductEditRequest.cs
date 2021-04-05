using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
    public class ProductEditRequest
    {

        public string Price { get; set; }

        public string OriginalPrice { get; set; }

        public int Stock { get; set; }

        public int ViewCount { get; set; }
    }
}
