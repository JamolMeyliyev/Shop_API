using Microsoft.EntityFrameworkCore;
using Shop_API.Entities;

namespace Shop_API.Context;

public class ShopDbContext:DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Genre> Genres { get; set; }    
    public DbSet<Publisher> Publisher { get; set; }
    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

    
}
