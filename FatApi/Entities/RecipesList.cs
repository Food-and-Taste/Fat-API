namespace FatApi.Entities
{
    public class RecipesList
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int ListId { get; set; }

        public Recipes? Recipes { get; set; }
        public Lists? List { get; set; }
    }
}
