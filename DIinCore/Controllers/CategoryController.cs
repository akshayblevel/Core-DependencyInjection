using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DIinCore.Controllers
{
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository { get; set; }
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Category> categories = categoryRepository.GetCategories();
            return Ok(categories);
        }
    }
}