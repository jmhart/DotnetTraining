using Domain.Interfaces;
using Infra.Data;

namespace Infra.Repositories
{
    public class ExampleRepository : IRepository<ExampleEntity>
    {
        public Task AddAsync(ExampleEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExampleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExampleEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ExampleEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ExampleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}