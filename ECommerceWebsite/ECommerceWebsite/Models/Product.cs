using ECommerceWebsite.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Product : IProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ManufacturerId { get; set; }
        public string Description { get; set; }
    }
}
