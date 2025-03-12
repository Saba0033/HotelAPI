using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelRepository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Guid Id, params Expression<Func<T, object>>[] IncludeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid Id);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> Predicate = null, params Expression<Func<T, object>>[] IncludeProperties);

    }
}