namespace FatApi.Entities
{
    public class Recipes
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Ingredients { get; set; } = string.Empty;
        //public byte[]? Image { get; set; }  
        public string Description { get; set; } = string.Empty;
        public int DifficultyId { get; set; }
        public int Time { get; set; }
        public int Cost { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public Difficulties? Difficulties { get; set; }
        public Users? Users { get; set; }
        public Categories? Categories { get; set; }

        public List<RecipesList> RecipesList { get; set; } = new();
        public List<Reviews> Reviews { get; set; } = new();
    }
}
