using Microsoft.EntityFrameworkCore;
using mvc_demo.Models;
public class AppDbContext : DbContext
{
    public DbSet<Item>? Items {get; set;}
    private readonly IConfiguration _configuration;
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("Default"));
    }
}
