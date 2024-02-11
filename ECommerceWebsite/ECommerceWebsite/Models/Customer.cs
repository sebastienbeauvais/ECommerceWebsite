using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        
    }
}
