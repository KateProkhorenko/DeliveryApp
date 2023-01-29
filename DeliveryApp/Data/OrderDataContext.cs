using DeliveryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Data
{
    public class OrderDataContext : DbContext
    {
        public OrderDataContext (DbContextOptions<OrderDataContext> opts)
                                : base(opts) { }
        public DbSet<Order> Orders => Set<Order>();
    }
}
