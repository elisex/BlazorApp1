using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Shared;
using BlazorApp1.Server.Services.CategoryService;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>>GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}
