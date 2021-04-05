using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Request
{
    public class AppUserEditRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
