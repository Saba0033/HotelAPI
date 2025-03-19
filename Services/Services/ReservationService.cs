using HotelAPI.Application.DTOs.ReservationDTOs;
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
    public class ReservationService : GenericService<Reservation,
        ReservationForGetDTO,
        ReservationForCreateDTO,
        ReservationForUpdateDTO>, IReservationService
    {
        public ReservationService(IGenericRepository<Reservation> repository, IValidator<Reservation> validator) : base(repository, validator)
        {
        }
    }
}
