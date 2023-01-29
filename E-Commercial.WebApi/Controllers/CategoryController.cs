using System.ComponentModel.DataAnnotations;
using eCommercial.Business.Abstract;
using eCommercial.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace E_Commercial.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public  CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpPost("addcategory")]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.Create(category);
            return Ok("İşlem Başarılı");
        }
    }
}
