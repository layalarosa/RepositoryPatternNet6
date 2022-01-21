using Microsoft.EntityFrameworkCore;
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

        public override async Task<IEnumerable<Product>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(ProductRepository));
                return new List<Product>();
            }
        }

        public override async Task<bool> Update(Product entity)
        {
            try
            {
                var existingProduct = await dbSet.Where(x => x.Id == entity.Id)
                                                        .FirstOrDefaultAsync();

                if (existingProduct == null)
                    return await Add(entity);

                existingProduct.Name = entity.Name;
                existingProduct.Price = entity.Price;
                existingProduct.PictureUrl = entity.PictureUrl;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(ProductRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.Id == id)
                                    .FirstOrDefaultAsync();

                if (exist != null)
                {
                    dbSet.Remove(exist);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete method error", typeof(ProductRepository));
                return false;
            }
        }
    }
}
