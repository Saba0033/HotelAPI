using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.CustomerDTOs
{
    public class CustomerForUpdateDTO
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}