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
        public async Task<IActionResult> Index()
        {
            var products=await productService.GetAllProduct();
            return View(products);
        }
    }
}
