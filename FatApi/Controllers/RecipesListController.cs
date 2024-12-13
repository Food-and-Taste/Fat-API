using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services;
using FatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FatApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RecipesListController: ControllerBase
    {
        private readonly IRecipesListServices _recipesListServices;

        public RecipesListController(IRecipesListServices recipesListServices)
        {
            _recipesListServices = recipesListServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecipesListResponseDto>>> GetAllRecipesList()
        {
            var recipesList = await _recipesListServices.GetAllRecipesList();
            return Ok(recipesList);
        }

        [HttpPost]
        public async Task<ActionResult<RecipesList>> AddRecipeList(RecipesListRequestDto recipeListDto)
        {
            var recipeList = await _recipesListServices.AddRecipeList(recipeListDto);
            return Ok(recipeList);
        }

        [HttpDelete("{recipesListId}")]
        public async Task<ActionResult<List<RecipesListResponseDto>>> DeleteRecipesListById(int recipesListId)
        {
            var deleteRecipe = await _recipesListServices.DeleteRecipesListById(recipesListId);
            return Ok(deleteRecipe);
        }
    }   
}
