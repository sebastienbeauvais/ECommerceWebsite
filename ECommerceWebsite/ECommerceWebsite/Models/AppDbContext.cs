using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWebsite.Models
{
    public class AppDbContext : DbContext
    {
        //Product table
        public DbSet<Product> Product { get; set; }

        // Connection to db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=?;database=?;uid=?;pwd=?");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
