﻿
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Request;
using eShopSolution.ViewModels.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appliaction.Interface
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllCategoryId (GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}