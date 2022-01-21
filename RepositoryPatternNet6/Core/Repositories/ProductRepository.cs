using RepositoryPatternNet6.Data;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }
    }
}
