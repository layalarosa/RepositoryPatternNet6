using RepositoryPatternNet6.Models;

namespace RepositoryPatternNet6.Core.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<bool> Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
