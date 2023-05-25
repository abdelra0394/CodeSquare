using Microsoft.EntityFrameworkCore;
namespace CodeSquare.Models
{
    public class SquareContext : DbContext
    {
        public SquareContext(DbContextOptions<SquareContext> options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Likes>().HasKey(e => e.Id);
        }
        public DbSet<Posts> posts { get; set; } = null!;
        public DbSet<Users> users { get; set; } = null!;

    }
}
