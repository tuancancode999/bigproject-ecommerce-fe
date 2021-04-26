﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
    public class CategoryCreateRequest
    {
       
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
