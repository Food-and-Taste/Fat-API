using FatApi.DataAccess;
using FatApi.Dto.ResponseDto;
using FatApi.Dto.RequestDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class RecipesServices: IRecipesServices
    {
        private readonly FatContext _fatContext;

        public RecipesServices(FatContext fatContext) 
        { 
            _fatContext = fatContext; 
        }

        public async Task<List<RecipesResponseDto>> GetAllRecipes()
        {
            return await _fatContext.Recipes.Select(recipe => new RecipesResponseDto
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Ingredients = recipe.Ingredients,
                //Image = recipe.Image != null ? Convert.ToBase64String(recipe.Image) : null,
                Description = recipe.Description,
                DifficultyId = recipe.DifficultyId,
                Time = recipe.Time,
                Cost = recipe.Cost,
                UserId = recipe.UserId,
                CategoryId = recipe.CategoryId,
            }).ToListAsync();
        }

        public async Task<Recipes> AddRecipes(RecipesRequestDto recipeDto)
        {
            var recipe = new Recipes
            {
                Name = recipeDto.Name,
                Ingredients = recipeDto.Ingredients,
                Description = recipeDto.Description,
                DifficultyId = recipeDto.DifficultyId,
                Time = recipeDto.Time,
                Cost = recipeDto.Cost,
                UserId = recipeDto.UserId,
                CategoryId = recipeDto.CategoryId,
                //Image = recipeDto.Image
            };

            _fatContext.Recipes.Add(recipe);
            await _fatContext.SaveChangesAsync();

            return recipe;
        }
    }
}
