namespace MVCProniaApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public string? Image { get; set; }
        public int Order { get; set; }
    }
}
