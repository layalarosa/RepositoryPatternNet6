using Microsoft.EntityFrameworkCore;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Data
{
    public class ApplicationDbContext : DbContext
    {
        // the dbset property will tell ef core that we have
        // a table that needs to be created if doesnt exist
        public virtual DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
