using AutoMapper;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.AutoMapper
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<ProductEditRequest, Product>();
            CreateMap<ProductEditRequest, ProductTranslation>();
        }
    }
}
