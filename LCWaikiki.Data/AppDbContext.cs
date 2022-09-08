using LCWaikiki.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Delivery> Deliverys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
