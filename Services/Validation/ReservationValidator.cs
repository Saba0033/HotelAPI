using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelModels.Entities;

namespace HotelServices.Validation
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.CheckIn).NotNull().WithMessage("CheckIn date is required");
            RuleFor(x => x.CheckOut).NotNull().WithMessage("CheckOut date is required");
            RuleFor(x => x.RoomId).NotNull().WithMessage("RoomId is required");
            RuleFor(x => x.CheckOut).GreaterThan(x => x.CheckIn);
        }
    }
}
