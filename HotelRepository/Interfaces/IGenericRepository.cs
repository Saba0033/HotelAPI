using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelRepository.Interfaces
{
    public interface IGenericRepository<T, TGetDto> where T: class
        where TGetDto: class
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] IncludeProperties);
        Task DeleteAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> Predicate = null, params Expression<Func<T, object>>[] IncludeProperties);
        Task SaveChanges();

        Task<List<TGetDto>> GetAllAsyncProjection<TGetDto>(
            Expression<Func<T, bool>> predicate = null);


    }
}