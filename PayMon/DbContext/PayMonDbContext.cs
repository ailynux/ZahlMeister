using Microsoft.EntityFrameworkCore;
using PayMon.Models;

namespace PayMon.Data // Changed from PayMon.DbContext to PayMon.Data
{
    public class PayMonDbContext : DbContext
    {
        public PayMonDbContext(DbContextOptions<PayMonDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
    }
}
