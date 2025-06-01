using EndPoint.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            var products=await productService.GetAllProduct();
            return View(products);
        }
        [HttpGet("detail")]
        public async Task<IActionResult> Detail(long id)
        {
            var product = await productService.GetProductById(id);
            return View(product);
        }
    }
}
