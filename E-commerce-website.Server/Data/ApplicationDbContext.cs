using E_commerce_website.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace E_commerce_website.Server.Data
{
    public class ApplicationDbContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
        : base(dbContextOptions)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }

    }
}
