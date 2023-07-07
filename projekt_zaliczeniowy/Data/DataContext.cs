using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projekt_zaliczeniowy.Models;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace projekt_zaliczeniowy.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
     
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

            modelBuilder.Entity<Ingredient>()
                .Property(b => b.Protein)
            .HasPrecision(16, 4);

            modelBuilder.Entity<Ingredient>()
                .Property(b => b.Fat)
                .HasPrecision(16,4);

            modelBuilder.Entity<Ingredient>()
                .Property(b => b.Carbohydrates)
            .HasPrecision(16, 4);

            modelBuilder.Entity<Ingredient>()
                .Property(b => b.Quantity)
                .HasPrecision(16,4);
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Ingredient> Ingredient { get; set;}
    }
}
