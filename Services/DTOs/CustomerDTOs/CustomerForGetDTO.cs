﻿using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.ReservationDTOs;

namespace HotelAPI.Application.DTOs.CustomerDTOs
{
    public class CustomerForGetDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<ReservationForCustomerDTO>? Reservations { get; set; }
    }
}
