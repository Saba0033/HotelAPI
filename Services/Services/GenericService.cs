using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FluentValidation;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using Mapster;

namespace HotelServices.Services
{
    public class GenericService<TEntity, TEntityGetDTO, TEntityCreateDTO, TEntityUpdateDTO> 
        : IGenericService<TEntity, TEntityGetDTO, TEntityCreateDTO, TEntityUpdateDTO> 
        where TEntity : class
        where TEntityGetDTO : class
        where TEntityCreateDTO : class
        where TEntityUpdateDTO : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IValidator<TEntity> _validator;


        public GenericService(IGenericRepository<TEntity> repository, IValidator<TEntity> validator)
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

        public async Task DeleteAsync(string id)
        {
            if (!Guid.TryParse(id, out var validId)) throw new ArgumentException("Invalid GUID format.");

            await _repository.DeleteAsync(validId);
        }

        public async Task<List<TEntityGetDTO>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, 
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var result = await _repository.GetAllAsync(predicate, includeProperties);
            var mappedResult = result.Adapt<List<TEntityGetDTO>>();
            return mappedResult;
        }

        public async Task<TEntityGetDTO> GetAsync(string id)
        {
            if (!Guid.TryParse(id, out var validId)) throw new ArgumentException("Invalid GUID format.");
            var result  = await _repository.GetAsync(validId);
            var mappedResult = result.Adapt<TEntityGetDTO>();
            return mappedResult;
        }

        public async Task UpdateAsync(TEntityUpdateDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
            }

            var mapped = entity.Adapt<TEntity>();
            await ValidateEntityAsync(mapped);
            await _repository.UpdateAsync(mapped);
        }

        private async Task ValidateEntityAsync(TEntity entity)
        {
            var validationResult = await _validator.ValidateAsync(entity);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }
    }
}
