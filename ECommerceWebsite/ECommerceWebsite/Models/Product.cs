using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
    }
}
