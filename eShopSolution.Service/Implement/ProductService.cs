using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly EShopDBContext _context;
        private IMapper _mapper;
        public ProductService(IProductRepository productRepository , EShopDBContext context, IMapper mapper)
        {
            _productRepository = productRepository;
            _context = context;
            _mapper = mapper;
        }

        public async Task<Product> AddProductAsync(ProductCreateRequest request)
        {
              
            var product = _mapper.Map<Product>(request);
            return await _productRepository.AddAsync(product);
        }

        public async Task<Product> UpdateProductAsync(ProductEditRequest request)
        {
            var product = _mapper.Map<Product>(request);
            return await _productRepository.UpdateAsync(product);
        }

        public  Task DeleteProductAsync(Product product)
        {
            return  _productRepository.DeleteAsync(product);
        }

        public IEnumerable<Product> GetAllProductAsync()
        {
            return _productRepository.GetAll();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }
    }
}
