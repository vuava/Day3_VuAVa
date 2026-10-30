using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Day3_vuava.Models
{
    public class Category
    {
        [Required(ErrorMessage = " Category ID is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
            [StringLength(100, MinimumLength = 5, ErrorMessage ="neeg zoo nkauj ")]
        public string Name { get; set; } = string.Empty;
        public List<Product>? Products { get; set; } 
    }
}
