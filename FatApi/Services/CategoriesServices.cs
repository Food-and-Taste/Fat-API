using FatApi.DataAccess;
using FatApi.Dto.ResponseDto;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FatApi.Services
{
    public class CategoriesServices: ICategoriesServices
    {
        private readonly FatContext _fatContext;

        public CategoriesServices(FatContext fatContext)
        {
            _fatContext = fatContext;
        }

        public async Task<CategoriesResponseDto?> GetCategoryById(int categoryId)
        {
            var category = await _fatContext.Categories.FindAsync(categoryId);

            if (category == null)
                return null;

            return new CategoriesResponseDto
            {
                Id = category.Id,
                Category = category.Category
            };
        }
    }
}
