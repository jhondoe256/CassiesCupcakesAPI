
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<CupCake> CupCakes { get; set; }
    public DbSet<Shop> Shops { get; set; }
}
