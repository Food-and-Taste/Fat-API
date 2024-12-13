namespace FatApi.Entities
{
    public class Categories
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;

        public List<Recipes> Recipes { get; set; } = new List<Recipes>();
    }
}
