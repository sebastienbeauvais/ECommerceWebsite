namespace ECommerceWebsite.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int ManufacturerId { get; set; }
        string Description { get; set; }

    }
}
