using RepositoryPatternNet6.Data;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }
    }
}
