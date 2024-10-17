using Microsoft.EntityFrameworkCore;
using VerticalSlice.Entities;

namespace VerticalSlice.Database;

public class ProductsDbContext : DbContext
{
    public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }
}
