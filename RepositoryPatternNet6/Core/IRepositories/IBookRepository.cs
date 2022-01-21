using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.IRepositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<User>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
