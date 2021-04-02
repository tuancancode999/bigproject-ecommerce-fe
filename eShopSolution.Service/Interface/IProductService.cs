using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Interface
{
    public interface IProductService
    {
        Task<Product> AddProductAsync(ProductCreateRequest request);

        Task<Product> UpdateProductAsync(ProductEditRequest request);

        Task  DeleteProductAsync(Product product);

        IEnumerable<Product> GetAllProductAsync();

        Task<Product> GetProductByIdAsync(int id);
    }
}
