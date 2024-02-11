using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}