using BookSwaping.Models;
using Microsoft.EntityFrameworkCore;

namespace BookSwaping.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                
                
                
                );


            base.OnModelCreating(modelBuilder);
        }

    }
}
