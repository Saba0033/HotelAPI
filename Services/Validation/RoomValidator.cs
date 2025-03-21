using FluentValidation;
using HotelModels.Entities;

namespace HotelServices.Validation
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage("Room name is required.")
                .Length(3, 100).WithMessage("Room name must be between 3 and 100 characters.");
            RuleFor(r => r.Price)
                .GreaterThan(0).WithMessage("Price must be greater than zero.").LessThanOrEqualTo(10000).WithMessage("Price must be less than 10000");
            RuleFor(r => r.HotelId)
                .NotEmpty().WithMessage("HotelId is required.");

        }
    }
}