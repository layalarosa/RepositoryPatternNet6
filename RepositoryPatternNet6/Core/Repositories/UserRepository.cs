using Microsoft.EntityFrameworkCore;
using RepositoryPatternNet6.Data;
using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(
            ApplicationDbContext context,
            ILogger logger
        ) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<User>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserRepository));
                return new List<User>();
            }
        }

        public override async Task<bool> Update(User entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.Id == entity.Id)
                                                        .FirstOrDefaultAsync();

                if (existingUser == null)
                    return await Add(entity);

                existingUser.FirstName = entity.FirstName;
                existingUser.LastName = entity.LastName;
                existingUser.Email = entity.Email;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(UserRepository));
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
                _logger.LogError(ex, "{Repo} Delete method error", typeof(UserRepository));
                return false;
            }
        }
    }
}
