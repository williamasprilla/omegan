using Omegan.Domain.Common;

namespace Omegan.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

        Task<int> Complete();
    }
}
