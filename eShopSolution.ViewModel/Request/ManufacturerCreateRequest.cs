using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
    public class ManufacturerCreateRequest
    {
        public string ManufactureName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public Status Status { get; set; }
    }
}
