using ECommerceWebsite.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ECommerceWebsite.Models
{
    public class Sale : ISale
    {
        [Key]
        public int Id { get; set; }
        public int NumItems { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}
