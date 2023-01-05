using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
    {
        
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Item> Items { get; set; }
}