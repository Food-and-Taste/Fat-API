using FatApi.Dto.RequestDto;
using FatApi.Dto.ResponseDto;
using FatApi.Entities;

namespace FatApi.Services.Interfaces
{
    public interface IRecipesServices
    {
        Task<List<RecipesResponseDto>> GetAllRecipes();
        Task<Recipes> AddRecipes(RecipesRequestDto recipeDto);
    }
}
