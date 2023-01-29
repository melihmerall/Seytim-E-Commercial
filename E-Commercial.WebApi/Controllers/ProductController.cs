using eCommercial.Business.Abstract;
using eCommercial.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace E_Commercial.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

    }
}
