using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using eShopSolution.ViewModels.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface IProductApiService
    {
        Task<Product> AddProductAsync(ProductCreateRequest request);

        Task<Product> UpdateProductAsync(ProductEditRequest request);

        Task<bool> DeleteProductAsync(Product product);

        IEnumerable<Product> GetAllProductAsync();

        Task<Product> GetProductByIdAsync(int id);
    }
}
