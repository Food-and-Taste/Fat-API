namespace FatApi.Entities
{
    public class Reviews
    {
        public int Id { get; set; }
        public string Review { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int RecipeId { get; set; }

        public Users? Users { get; set; }
        public Recipes? Recipes { get; set; }
    }
}
