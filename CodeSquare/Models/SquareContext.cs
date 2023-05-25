using Microsoft.EntityFrameworkCore;
namespace CodeSquare.Models
{
    public class SquareContext : DbContext
    {
        public SquareContext(DbContextOptions<SquareContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Likes>().HasKey(e => new { e.UserId, e.PostId});
        }
        public DbSet<Post> posts { get; set; } = null!;
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Likes> likes { get; set; } = null!;


    }
}
