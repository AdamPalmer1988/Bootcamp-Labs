using Microsoft.EntityFrameworkCore;
namespace AdoptionMVC.Models.data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Animal> Animals { get; set; }
}
