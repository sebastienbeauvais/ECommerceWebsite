using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerceWebsite.Models
{
    public class AppDbContext : DbContext
    {
        //Product table
        public DbSet<Product> Product { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Sale> Sale { get; set; }

        // Config db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            
            string eCommerceDbConnectionString = _configuration.GetConnectionString("eCommerceDb");

            optionsBuilder.UseMySQL(eCommerceDbConnectionString);
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
