using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly EShopSolutionDBContext _context;
        private IMapper _mapper;
      

        public ProductService(IProductRepository productRepository, EShopSolutionDBContext context, IMapper mapper)
        {
            _productRepository = productRepository;
            _context = context;
            _mapper = mapper;
            

        }
        public async Task<Product> AddProductAsync(ProductCreateRequest request)
        {
            var Product = _mapper.Map<Product>(request);
            return await _productRepository.AddAsync(Product);
        }

        public Task DeleteProductAsync(Product product)
        {
            return _productRepository.DeleteAsync(product);
        }

        public IEnumerable<Product> GetAllProductAsync()
        {
            return _productRepository.GetAll();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public int numberPage(int totalProduct, int limit)
        {
            float numberpage = totalProduct / limit;
            return (int)Math.Ceiling(numberpage);

        }

        public IEnumerable<Product> paginationProduct(int start, int limit)
        {
            var data = (from s in _context.Products.ToList() select s);
            var dataProduct = data.OrderBy(x => x.Id).Skip(start).Take(limit);
            return dataProduct.ToList();

        }

        public IEnumerable<Product> Search(string searchString)
        {
            var links = from l in _context.Products.ToList() // lấy toàn bộ liên kết
                        select l;

            if (!String.IsNullOrEmpty(searchString)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                links = links.Where(s => s.NameProduct.Contains(searchString)); //lọc theo chuỗi tìm kiếm
            }

            return links;
        }

        public int totalProduct()
        {
            return _context.Products.ToList().Count;

        }

        public async Task<Product> UpdateProductAsync(ProductEditRequest request)
        {
            var Product = _mapper.Map<Product>(request);
            return await _productRepository.UpdateAsync(Product);
        }

        
    }
}
