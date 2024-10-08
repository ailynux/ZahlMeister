using Microsoft.EntityFrameworkCore;
using PayMon.Models;

namespace PayMon.Data
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
