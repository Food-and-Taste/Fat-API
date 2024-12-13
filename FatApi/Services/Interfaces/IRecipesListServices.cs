using FatApi.Dto.ResponseDto;
using FatApi.Dto.RequestDto;
using FatApi.Entities;

namespace FatApi.Services.Interfaces
{
    public interface IRecipesListServices
    {
        Task<List<RecipesListResponseDto>> GetAllRecipesList();
        Task<RecipesList> AddRecipeList(RecipesListRequestDto recipeListDto);
        Task<List<RecipesListResponseDto>> DeleteRecipesListById(int recipesListId);
    }
}
