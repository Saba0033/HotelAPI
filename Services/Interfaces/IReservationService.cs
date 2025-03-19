using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace HotelAPI.Application.Interfaces
{
    public interface IReservationService : IGenericService<Reservation, 
        ReservationForGetDTO, 
        ReservationForCreateDTO,
        ReservationForUpdateDTO>
    {
    }
}
