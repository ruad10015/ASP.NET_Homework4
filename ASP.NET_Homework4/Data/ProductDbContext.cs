using ASP.NET_Homework4.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Homework4.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option)
            : base(option) { }

        public DbSet<Product> Products { get; set; }
    }
}
