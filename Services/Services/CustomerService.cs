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
        private IGenericRepository<Customer, CustomerForGetDTO> GRepository;
        public CustomerService(IGenericRepository<Customer, CustomerForGetDTO> repository, IValidator<Customer> validator) : base(repository, validator)
        {
            GRepository = repository;
        }


        public  override async Task UpdateAsync(CustomerForUpdateDTO entity)
        {
            var customer = await GetAsyncWithoutDTO(x => x.Id == entity.Id);
            if (customer == null) throw new ArgumentException("Customer not found");
            if (entity.FirstName != null) customer.FirstName = entity.FirstName;
            if (entity.LastName != null) customer.LastName = entity.LastName;
            if (entity.Email != null)
            {
                customer.Email = entity.Email;
                customer.UserName = entity.Email;
                customer.NormalizedUserName = entity.Email.ToUpper();
            }
            if (entity.PhoneNumber != null) customer.PhoneNumber = entity.PhoneNumber;
        }
    }
}
