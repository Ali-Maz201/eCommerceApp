using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductFeatures.CreateProductUseCase;

namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICreateProduct _createProduct;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ICreateProduct createProduct, ILogger<ProductController> logger)
        {
            _createProduct = createProduct;
            _logger = logger;
        }


        [HttpGet("ProductsPagination")]
        public IActionResult GetProductsForPagination()
        {
            _logger.LogError("am intrat in metoda");
            return Ok("Hello");
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest request)
        {
            await _createProduct.Create(request);
            return Ok();
        }
    }
}
