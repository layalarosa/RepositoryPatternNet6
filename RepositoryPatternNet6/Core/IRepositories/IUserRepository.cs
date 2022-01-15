using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.IRepositories
{
    public class IUserRepository : IGenericRepository<User>
    {
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
