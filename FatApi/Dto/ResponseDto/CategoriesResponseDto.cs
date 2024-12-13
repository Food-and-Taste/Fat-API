using FatApi.Entities;

namespace FatApi.Dto.ResponseDto
{
    public class CategoriesResponseDto
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
