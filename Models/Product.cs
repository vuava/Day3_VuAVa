namespace Day3_vuava.Models
{
    public class @Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string price { get; set; }
        public String? description { get; set; }
        public int categoryId { get; set; }
        public Category? category { get; set; }

    }
}
