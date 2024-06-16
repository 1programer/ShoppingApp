using Microsoft.EntityFrameworkCore;
using shoppingApp.Models;

namespace shoppingApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
