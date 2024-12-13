namespace FatApi.Entities
{
    public class Lists
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public Users? Users { get; set; }

        public List<RecipesList> RecipesList { get; set; } = new();
    }
}
