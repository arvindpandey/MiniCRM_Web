using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCRM.Services.Interfaces;

namespace MiniCRM_Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _iproductService;
        public ProductController(IProduct iproductService)
        {
            _iproductService = iproductService;
        }
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await _iproductService.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProductAsync(MiniCRM.Core.Entities.Product product)
        {
            var newProduct = await _iproductService.AddProductAsync(product);
            return Ok(newProduct);
        }
    }
}
