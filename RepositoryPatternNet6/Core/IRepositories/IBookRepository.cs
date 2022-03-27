using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.IRepositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        public Task<bool> Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<Book>> All()
        {
            throw new NotImplementedException();
        }

        public new Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
