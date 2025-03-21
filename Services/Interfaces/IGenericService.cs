﻿using System;
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
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<TEntityGetDTO> GetAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task AddAsync(TEntityCreateDTO entity);
        Task UpdateAsync(TEntityUpdateDTO entity);
        Task DeleteAsync(Expression<Func<TEntity,bool>> predicate);
        Task SaveChanges();
        Task<List<TEntityGetDTO>> GetAllAsyncProjection<TGetDto>(
            Expression<Func<TEntity, bool>> predicate = null);

        Task<TEntity> GetAsyncWithoutDTO(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
