using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public Status Status { get; set; }

     
    }
}
