namespace FatApi.Dto.RequestDto
{
    public class ReviewsRequestDto
    {
        public string Review { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int RecipeId { get; set; }
    }
}
