namespace FatApi.Dto.RequestDto
{
    public class RecipesRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Ingredients { get; set; } = string.Empty;
        //public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DifficultyId { get; set; }
        public int Time { get; set; }
        public int Cost { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
