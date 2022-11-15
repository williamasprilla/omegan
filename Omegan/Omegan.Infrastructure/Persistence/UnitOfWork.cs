using Omegan.Application.Contracts.Persistence;
using Omegan.Domain.Common;
using Omegan.Infrastructure.Repositories;
using System.Collections;

namespace Omegan.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable _repositories;

        private readonly OmeganDbContext _context;

        public UnitOfWork(OmeganDbContext context)
        {
            _context = context;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {

                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);    
                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<TEntity>)_repositories[type];
        }
    }
}
