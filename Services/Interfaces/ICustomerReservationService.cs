using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.CustomerReservationDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;

namespace HotelAPI.Application.Interfaces
{
    public interface ICustomerReservationService : IGenericService<CustomerReservation,
        CustomerReservationForGet,
        CustomerReservationForCreate,
        CustomerReservationForUpdate>
    {

    }
}
