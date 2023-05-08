using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace home_56.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Role>().HasData(new Role { Id = 1, Name = "admin" });
            model.Entity<Role>().HasData(new Role { Id = 2, Name = "user" });
            model.Entity<User>().HasData(new User { Id = 1, Email = "admin@admin.admin", Password = "1qwe@QWE", RoleId = 1 });
        }
    }
}
