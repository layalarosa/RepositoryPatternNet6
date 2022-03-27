using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.IRepositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        public Task<bool> Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<Author>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<Author> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
