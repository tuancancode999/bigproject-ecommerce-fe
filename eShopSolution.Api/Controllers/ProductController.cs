using eShopSolution.Service.Interface;
using eShopSolution.ViewModels.Request;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var products = _productService.GetAllProductAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> EditByIdProduct(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var Data = await _productService.GetProductByIdAsync(id);
            if (Data == null)
            {
                return BadRequest();
            }
            return Ok(Data);
        }


        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _productService.AddProductAsync(request);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete("Id")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Data = await _productService.GetProductByIdAsync(id);
            if (Data != null)
            {
                await _productService.DeleteProductAsync(Data);
                return Ok();
            }
            if (Data == null)
            {
                return NotFound();
            }

            return BadRequest();
        }


        [HttpPut("{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> EditProduct([FromRoute]  int id, [FromForm] ProductEditRequest request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                 await _productService.UpdateProductAsync(request);
                return Ok();     
            }
            return BadRequest();
        }

    }
}
