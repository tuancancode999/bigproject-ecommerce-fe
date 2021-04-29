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
            CreateMap<RegisterRequest, AppUser>();
            CreateMap<CategoryCreateRequest, Category>();
            CreateMap<CategoryEditRequest, Category>();
            CreateMap<ManufacturerCreateRequest, Manufacturer>();
            CreateMap<ManufacturerEditRequest, Manufacturer>();
            CreateMap<PromotionCreateRequest, Promotion>();
            CreateMap<PromotionEditRequest, Promotion>();
            CreateMap<OrderCreateRequest, Order>();
            CreateMap<OrderEditRequest, Order>();
            CreateMap<TransactionCreateRequest, Transactions>();
            CreateMap<TransactionEditRequest, Transactions>();
            CreateMap<SizeCreateRequest, Sizes>();
            CreateMap<SizeEditRequest, Sizes>();
            CreateMap<FeatBackCreateRequest, FeatBack>();
            CreateMap<FeatBackEditRequest, FeatBack>();
            CreateMap<NotificationCreateRequest, Notification>();
            CreateMap<NotificationEditRequest, Notification>();
            CreateMap<AppUserEditRequest, AppUser>();
            CreateMap<AppRoleCreateRequest, AppRole>();
            CreateMap<AppRoleEditRequest, AppRole>();
            CreateMap<CartCreateRequest, Cart>();
            CreateMap<CartEditRequest, Cart>();
        }
    }
}
