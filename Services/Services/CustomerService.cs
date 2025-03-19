using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using HotelRepository.Interfaces;
using HotelServices.Services;

namespace HotelAPI.Application.Services
{
    public class CustomerService : GenericService<Customer, 
        CustomerForGetDTO, 
        CustomerForCreateDTO, 
        CustomerForUpdateDTO>, ICustomerService
    {
        private IGenericRepository<Customer> GRepository;
        public CustomerService(IGenericRepository<Customer> repository, IValidator<Customer> validator) : base(repository, validator)
        {
            GRepository = repository;
        }

     

    }
}
