using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public interface IFeatBackService
    {
        Task<FeatBack> AddCategoryAsync(FeatBackCreateRequest request);

        Task<FeatBack> UpdateCategoryAsync(FeatBackEditRequest request);

        Task DeleteFeatBackAsync(FeatBack featBack);

        IEnumerable<FeatBack> GetAllFeatBackAsync();

        Task<FeatBack> GetFeatBackByIdAsync(int id);
    }
}
