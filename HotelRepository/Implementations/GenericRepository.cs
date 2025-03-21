using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelModels.Data;
using HotelRepository.Interfaces;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace HotelRepository.Implementations
{
    public class GenericRepository<T, TGetDto>(HotelContext _context) : IGenericRepository<T, TGetDto> 
        where T : class
        where TGetDto : class

    {

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> Predicate = null
            , params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var IncludeProperty in IncludeProperties)
            {
                query = query.Include(IncludeProperty);
            }
            var result = Predicate == null ? await query.ToListAsync() : await query.Where(Predicate).ToListAsync();
            return result;
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> query = _context.Set<T>();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(predicate);
        }

 

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var toDelete = await GetAsync(predicate);
            _context.Set<T>().Remove(toDelete);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<List<TGetDto>> GetAllAsyncProjection<TGetDto>(
            Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate != null)
                query = query.Where(predicate);

            var result = await query.ProjectToType<TGetDto>().ToListAsync();
            return result;
        }

    }
}