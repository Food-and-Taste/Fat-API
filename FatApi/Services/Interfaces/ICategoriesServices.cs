using FatApi.Dto.ResponseDto;

namespace FatApi.Services.Interfaces
{
    public interface ICategoriesServices
    {
        Task<CategoriesResponseDto> GetCategoryById(int categoryId);
    }
}
