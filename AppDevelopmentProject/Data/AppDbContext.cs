using AppDevelopmentProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;

namespace AppDevelopmentProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public AppDbContext()
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<WareHouse>().ToTable("warehouses");

            modelBuilder.Entity<Order>().HasOne(d => d.User).WithMany()
                                           .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);

            modelBuilder.Entity<Order>().HasOne(d => d.WareHouse).WithMany()
                                           .HasForeignKey(x => x.WareHouseId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);

        }
    }
}
