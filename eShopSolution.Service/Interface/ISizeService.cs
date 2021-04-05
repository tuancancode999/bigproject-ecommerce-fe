using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface ISizeService
    {
        Task<Sizes> AddSizeAsync(SizeCreateRequest request);

        Task<Sizes> UpdateSizeAsync(SizeEditRequest request);

        Task DeleteSizeAsync(Sizes sizes);

        IEnumerable<Sizes> GetAllSizeAsync();

        Task<Sizes> GetSizesByIdAsync(int id);
    }
}
