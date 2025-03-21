using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelModels.Entities
{
    public class CustomerReservation
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ReservationId { get; set; }
        public Customer? Customer { get; set; }
        public Reservation? Reservation { get; set; }
       
    }
}
