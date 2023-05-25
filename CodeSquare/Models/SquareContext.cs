using Microsoft.EntityFrameworkCore;
namespace CodeSquare.Models
{
    public class SquareContext : DbContext
    {
        public SquareContext(DbContextOptions<SquareContext> options)
       : base(options)
        {
        }

        public DbSet<Posts> posts { get; set; } = null!;
        public DbSet<Users> users { get; set; } = null!;

    }
}
