using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Exceptions
{
    public class DuplicateEntryException : Exception
    {
        public DuplicateEntryException(string message) : base(message)
        { }

        public DuplicateEntryException() : base("Duplicate entry detected. Please use a different value.")
        {

        }
    }
}
