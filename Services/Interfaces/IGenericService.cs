using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelServices.Interfaces
{
    public interface IGenericService<TEntity, TEntityGetDTO, TEntityCreateDTO, TEntityUpdateDTO> 
        where TEntity : class
        where TEntityGetDTO : class
        where TEntityCreateDTO : class
        where TEntityUpdateDTO : class
    {
        Task<List<TEntityGetDTO>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeProperties = null);

        Task<TEntityGetDTO> GetAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeProperties = null);

        Task AddAsync(TEntityCreateDTO entity);
        Task UpdateAsync(TEntityUpdateDTO entity);
        Task DeleteAsync(Expression<Func<TEntity,bool>> predicate);
        Task SaveChanges();
        Task<List<TEntityGetDTO>> GetAllAsyncProjection<TGetDto>(Expression<Func<TEntity, bool>> predicate = null);

        Task<TEntity> GetAsyncWithoutDTO(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeProperties = null);
    }
}
