using Omegan.Application.Contracts.Specifications;
using Omegan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Persistence
{
   
    public interface IGenericRepository<T> where T : BaseDomainModel
    {

        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);

        Task<int> CountAsync(ISpecification<T> spec);

        Task<int> Add(T entity);

        Task<int> Update(T entity);

        void AddEntity(T Entity);

        void UpdateEntity(T Entity);

        void DeleteEntity(T Entity);

    }
}
