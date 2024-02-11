using ECommerceWebsite.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
 

namespace ECommerceWebsite.Models
{
    public class Customer : ICustomer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
    }
}
