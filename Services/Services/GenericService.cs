using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.Exceptions;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using Mapster;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//using static FluentValidation.Validators.PredicateValidator<T, TProperty>;

namespace HotelServices.Services
{
    public class GenericService<TEntity, TEntityGetDTO, TEntityCreateDTO, TEntityUpdateDTO> 
        : IGenericService<TEntity, TEntityGetDTO, TEntityCreateDTO, TEntityUpdateDTO> 
        where TEntity : class
        where TEntityGetDTO : class
        where TEntityCreateDTO : class
        where TEntityUpdateDTO : class
    {
        private readonly IGenericRepository<TEntity, TEntityGetDTO> _repository;
        private readonly IValidator<TEntity> _validator;


        public GenericService(IGenericRepository<TEntity, TEntityGetDTO> repository, IValidator<TEntity> validator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public  async Task AddAsync(TEntityCreateDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            }

            TEntity mapped = entity.Adapt<TEntity>();
            await ValidateEntityAsync(mapped);
            await _repository.AddAsync(mapped);
        }

        public virtual async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            await _repository.DeleteAsync(predicate);
        }

        public async Task<List<TEntityGetDTO>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var result = await _repository.GetAllAsync(predicate, includeProperties);
            
            var mappedResult = result.Adapt<List<TEntityGetDTO>>();
            return mappedResult;
        }

     
        public async Task<TEntityGetDTO> GetAsync(Expression<Func<TEntity,bool >> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var result = await _repository.GetAsync(predicate, includeProperties);
            var mappedResult = result.Adapt<TEntityGetDTO>();
            return mappedResult;
        }

        public async Task<TEntity> GetAsyncWithoutDTO(Expression<Func<TEntity, bool >> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var result = await _repository.GetAsync(predicate, includeProperties);
            return result;
        }


        public virtual async Task UpdateAsync(TEntityUpdateDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            }

            var mapped = entity.Adapt<TEntity>();
            await ValidateEntityAsync(mapped);
            await _repository.UpdateAsync(mapped);
        }


        public async Task SaveChanges()
        {
            
            await _repository.SaveChanges();
           

        }

        private async Task ValidateEntityAsync(TEntity entity)
        {
            var validationResult = await _validator.ValidateAsync(entity);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }

        public async Task<List<TEntityGetDTO>> GetAllAsyncProjection<TEntityGetDto>(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _repository.GetAllAsyncProjection<TEntityGetDTO>(predicate);
        }
    }
}
