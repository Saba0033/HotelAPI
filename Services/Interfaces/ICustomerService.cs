using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace HotelAPI.Application.Interfaces
{
    public interface ICustomerService : IGenericService<Customer, 
        CustomerForGetDTO, 
        CustomerForCreateDTO, 
        CustomerForUpdateDTO>
    {
    }
}
