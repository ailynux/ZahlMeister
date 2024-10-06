using Microsoft.EntityFrameworkCore;
using PayMon.Models;

namespace PayMon.DbContext
{
    public class PayMonDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PayMonDbContext(DbContextOptions<PayMonDbContext> options) : base(options) { }

        public DbSet<Payment> Payments { get; set; }
    }
}
