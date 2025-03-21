using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Exceptions
{
    public class ActiveReservationException : Exception
    {
        public ActiveReservationException() : base("Cannot delete hotel with active reservations")
        {
        }
    }
}
