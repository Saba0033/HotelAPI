﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.CustomerReservationDTOs
{
    public class CustomerReservationForCreate
    {
        public Guid CustomerId { get; set; }
        public Guid ReservationId { get; set; }
    }
}
