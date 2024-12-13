using FatApi.DataAccess;
using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class RecipesListServices: IRecipesListServices
    {
        private readonly FatContext _fatContext;

        public RecipesListServices(FatContext fatContext)
        {
            _fatContext = fatContext;
        }

        public async Task<List<RecipesListResponseDto>> GetAllRecipesList()
        {
            return await _fatContext.RecipesList.Select(recipeList => new RecipesListResponseDto
            {
                Id = recipeList.Id,
                RecipeId = recipeList.RecipeId,
                ListId = recipeList.ListId
            }).ToListAsync();
        }

        public async Task<RecipesList> AddRecipeList(RecipesListRequestDto recipeListDto)
        {
            var recipeList = new RecipesList
            {
                RecipeId = recipeListDto.RecipeId,
                ListId = recipeListDto.ListId
            };

            _fatContext.RecipesList.Add(recipeList);
            await _fatContext.SaveChangesAsync();

            return recipeList;
        }

        public async Task<List<RecipesListResponseDto>> DeleteRecipesListById(int recipesListId)
        {
            var recipesList = await _fatContext.RecipesList.FindAsync(recipesListId);

            _fatContext.RecipesList.Remove(recipesList);
            await _fatContext.SaveChangesAsync();

            return await GetAllRecipesList();
        }
    }
}