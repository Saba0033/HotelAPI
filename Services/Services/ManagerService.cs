using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.Interfaces;
using HotelRepository.Interfaces;
using HotelServices.Services;
using Humanizer;

namespace HotelAPI.Application.Services
{
    public class ManagerService : GenericService<Manager,
        ManagerForGettingDTO,
        ManagerForCreateDTO,
        ManagerForUpdateDTO>, IManagerService
    {
        private ICustomerService customerService;
        public ManagerService(IGenericRepository<Manager, ManagerForGettingDTO> repository,ICustomerService customerService, IValidator<Manager> validator) : base(repository, validator)
        {
            this.customerService = customerService;
        }

        public override async Task UpdateAsync(ManagerForUpdateDTO entity)
        {
            var manager = await GetAsyncWithoutDTO(x => x.ManagerId == entity.ManagerId);
            if (manager == null) throw new ArgumentException("Manager not found");
            if (entity.FirsName != null) manager.FirsName = entity.FirsName;
            if (entity.LastName != null) manager.LastName = entity.LastName;
            if (entity.Email != null) manager.Email = entity.Email;
            if (entity.PhoneNumber != null) manager.PhoneNumber = entity.PhoneNumber;
        }

        public override async Task AddAsync(ManagerForCreateDTO entity)
        {
            if (await customerService.GetAsync(x => x.IdentityNumber == entity.IdentityNumber) == null)
            {
                throw new NoMatchFoundException($"Manager with identity number {entity.IdentityNumber} is not registered");
            }
            base.AddAsync(entity);
        }
    }
}
