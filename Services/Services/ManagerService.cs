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

namespace HotelAPI.Application.Services
{
    public class ManagerService : GenericService<Manager,
        ManagerForGettingDTO,
        ManagerForCreateDTO,
        ManagerForUpdateDTO>, IManagerService
    {
        public ManagerService(IGenericRepository<Manager> repository, IValidator<Manager> validator) : base(repository, validator)
        {
        }
    }
}
