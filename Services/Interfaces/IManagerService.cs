using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;

namespace HotelAPI.Application.Interfaces
{
    public interface IManagerService : IGenericService<Manager, 
        ManagerForGettingDTO, 
        ManagerForCreateDTO, 
        ManagerForUpdateDTO>
    {
    }
}
