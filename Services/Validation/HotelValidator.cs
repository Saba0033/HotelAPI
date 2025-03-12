using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelModels.Entities;

namespace HotelServices.Validation
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            
            RuleFor(h => h.Name).NotEmpty().WithMessage("Hotel name is required.");
            RuleFor(h => (int)h.Rating).InclusiveBetween(1, 5).WithMessage("Rating must be between 1 and 5.");
            RuleFor(h => h.City).NotEmpty().WithMessage("City is required.");
            RuleFor(h => h.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(h => h.Address).NotEmpty().WithMessage("Address is required.");
        }
    }
}
