using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ClientInfo> ClientInfo { get; set; }
        public DbSet<Marketing> Marketing { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<EasyWeb> EasyWeb { get; set; }
    }
}