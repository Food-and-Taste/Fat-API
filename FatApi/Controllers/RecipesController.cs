using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RecipesController: ControllerBase
    {
        private readonly IRecipesServices _recipesServices;

        public RecipesController(IRecipesServices recipesServices)
        {
            _recipesServices = recipesServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Recipes>>> GetAllRecipes()
        {
            var recipes = await _recipesServices.GetAllRecipes();
            return Ok(recipes);
        }

        [HttpPost]
        public async Task<ActionResult<Recipes>> AddRecipe(RecipesRequestDto recipeDto)
        {
            var newRecipe = await _recipesServices.AddRecipes(recipeDto);
            return Ok(newRecipe);
        }
    }
}
