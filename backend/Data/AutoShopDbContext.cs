using Microsoft.EntityFrameworkCore;
using AutoShop.API.Models;

namespace AutoShop.API.Data {
    public class AutoShopDbContext : DbContext {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;

        public AutoShopDbContext(DbContextOptions<AutoShopDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
                modelBuilder.Entity<User>()
        .HasOne(u => u.Car)
        .WithMany(c => c.Users)
        .HasForeignKey(u => u.CarId)
        .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Car>().Property(c => c.Company).HasColumnType("TEXT");
        modelBuilder.Entity<Car>().Property(c => c.Model).HasColumnType("TEXT");
        modelBuilder.Entity<User>().Property(u => u.Name).HasColumnType("TEXT");
        modelBuilder.Entity<User>().Property(u => u.Email).HasColumnType("TEXT");
        modelBuilder.Entity<User>().Property(u => u.Password).HasColumnType("TEXT");

        //initials data
       modelBuilder.Entity<Car>().HasData(
        new Car { Id = 1, Company = "Toyota", Model = "Corolla", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
        new Car { Id = 2, Company = "Mazda", Model = "5", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
        new Car { Id = 3, Company = "Tesla", Model = "i", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
    );

    modelBuilder.Entity<User>().HasData(
        new User { Id = 1, Name = "shira", Email = "s@example.com", Password = "1234", CarId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
        new User { Id = 2, Name = "roni", Email = "bob@example.com", Password = "abcd", CarId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
    );
        }
    }
}