
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplication _productApplication;
        private readonly EShopDBContext _context;
        public ProductController(EShopDBContext context, IProductApplication productApplication)
        {
            _productApplication = productApplication;
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct(int page = 0, int pageSize = 5)
        {
            var model = await _productApplication.SelectAll<Product>();
            return model;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var model = await _productApplication.SelectById<Product>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            await _productApplication.UpdateAsync<Product>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> InsertProduct(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoTitle = request.SeoTitle,
                        SeoAlias = request.SeoAlias,
                        LanguageId = "vi"
                    }
                }
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var model = await _productApplication.SelectById<Product>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _productApplication.DeleteAsync<Product>(model);

            return model;
        }
    }
}
