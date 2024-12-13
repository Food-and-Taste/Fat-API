namespace FatApi.Dto.ResponseDto
{
    public class ReviewsResponseDto
    {
        public int Id { get; set; }
        public string Review { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int RecipeId { get; set; }
    }
}
