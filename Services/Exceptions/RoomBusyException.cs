using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Exceptions
{
    public class RoomBusyException : Exception
    {
        public RoomBusyException(string message) : base(message)
        {
        }
        public RoomBusyException() : base("Room is already reserved for this period")
        {
        }
    }
}
