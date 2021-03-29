using eShopSolution.Appliaction.Interface;
using eShopSolution.ViewModels.Request;
using eShopSolution.ViewModels.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductController (IPublicProductService publicProductService,IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        // http ://localhost:port/product 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }

        // http ://localhost:port/product/public-paging
        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllCategoryId(request);
            return Ok(products);
        }

        // http ://localhost:port/product/1
        [HttpGet("{id}/{languageId}")]
        public async Task<ProductViewModel> GetById(int id, string languageId)
        {
            var product = await _manageProductService.GetById(id, languageId);
            //if (product == null)
            //    return BadRequest("Cannot find product");
            return product;
        }


        // http ://localhost:port/product 
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _manageProductService.create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _manageProductService.GetById(productId ,request.LanguageId);

            return CreatedAtAction(nameof(GetById), new {id = productId },product);
        }


        [HttpPut]
        public async Task<IActionResult> Edit([FromForm] ProductEditRequest request)
        {
            var affectedResult = await _manageProductService.edit(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _manageProductService.delete(Id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }



    }
}
