using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface ICategoryService
    {
        Task<Category> AddCategoryAsync(CategoryCreateRequest request);

        Task<Category> UpdateCategoryAsync(CategoryEditRequest request);

        Task DeleteCategoryAsync(Category category);

        IEnumerable<Category> GetAllCategoryAsync();

        Task<Category> GetCategoryByIdAsync(int id);
    }
}
