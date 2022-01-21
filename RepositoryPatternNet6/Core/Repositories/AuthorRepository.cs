using Microsoft.EntityFrameworkCore;
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
        public override async Task<IEnumerable<Author>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(AuthorRepository));
                return new List<Author>();
            }
        }

        public override async Task<bool> Update(Author entity)
        {
            try
            {
                var existingAuthor = await dbSet.Where(x => x.Id == entity.Id)
                                                        .FirstOrDefaultAsync();

                if (existingAuthor == null)
                    return await Add(entity);

                existingAuthor.Name = entity.Name;


                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(AuthorRepository));
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
                _logger.LogError(ex, "{Repo} Delete method error", typeof(AuthorRepository));
                return false;
            }
        }
    }
}
