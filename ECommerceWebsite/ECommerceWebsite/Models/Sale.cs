using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public int numItems { get; set; }
        public decimal totalPrice { get; set; }
        public decimal discountPrice { get; set; }
        public int customerId { get; set; }
        public DateTime dateOfPurchase { get; set; }
    }
}
