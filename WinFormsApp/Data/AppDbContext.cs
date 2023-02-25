using Microsoft.EntityFrameworkCore;
using WinFormsApp.Entities;

namespace WinFormsApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUser>()
            .HasIndex(u => u.Username)
            .IsUnique();
        
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { Id = 1, Username = "user1", Password = "password1" },
            new AppUser { Id = 2, Username = "user2", Password = "password2" },
            new AppUser { Id = 3, Username = "user3", Password = "password3" }
        );
    }
}
