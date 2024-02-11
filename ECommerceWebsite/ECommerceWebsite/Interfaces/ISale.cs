namespace ECommerceWebsite.Interfaces
{
    public interface ISale
    {
        int Id { get; set; }
        int NumItems { get; set; }
        decimal TotalPrice { get; set; }
        decimal? DiscountPrice {get; set;}
        int CustomerId { get; set; }
        DateTime DateOfPurchase { get; set; }
    }
}
