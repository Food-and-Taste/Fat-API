using FatApi.Dto.ResponseDto;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategoriesController: ControllerBase
    {
        private readonly ICategoriesServices _categories;

        public CategoriesController(ICategoriesServices categories)
        {
            _categories = categories;
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<CategoriesResponseDto>> GetCategoryById(int categoryId)
        {
            var category = await _categories.GetCategoryById(categoryId);
            return Ok(category);
        }
    }
}
