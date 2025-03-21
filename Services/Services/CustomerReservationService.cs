using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerReservationDTOs;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using HotelRepository.Interfaces;
using HotelServices.Services;

namespace HotelAPI.Application.Services
{
    public class CustomerReservationService : 
        GenericService<CustomerReservation,
            CustomerReservationForGet,
            CustomerReservationForCreate,
            CustomerReservationForUpdate>, ICustomerReservationService
    {
        public CustomerReservationService(IGenericRepository<CustomerReservation, CustomerReservationForGet> repository, IValidator<CustomerReservation> validator) : base(repository, validator)
        {
        }
    }
}
