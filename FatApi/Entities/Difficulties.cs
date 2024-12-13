namespace FatApi.Entities
{
    public class Difficulties
    {
        public int Id { get; set; }
        public string Difficulty { get; set; } = string.Empty;

        public List<Recipes> Recipes { get; set; } = new List<Recipes>();
    }
}