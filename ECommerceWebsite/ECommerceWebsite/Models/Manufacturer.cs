using ECommerceWebsite.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Manufacturer : IManufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}