using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
   public interface IPromotionService
    {
        Task<Promotion> AddManufacturerAsync(PromotionCreateRequest request);

        Task<Promotion> UpdatePromotionAsync(PromotionEditRequest request);

        Task DeletePromotionAsync(Promotion promotion);

        IEnumerable<Promotion> GetAllPromotionAsync();

        Task<Promotion> GetPromotionByIdAsync(int id);
    }
}
