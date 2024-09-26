using Microsoft.EntityFrameworkCore;
using RestaurantFaves.Models;

namespace RestaurantFaves.Data;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
    {

    }

    public virtual DbSet<Order> Orders { get; set; }

}
