using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelModels.Entities
{
    public class Reservation
    {
        public Guid ReservationId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }
        public List<CustomerReservation>? Customers { get; set; }

    }
}
