using FluentValidation;
using HotelApi2.Application.Models;
using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Validators
{
    public class RoomValidator : AbstractValidator<RoomDto>
    {
        public RoomValidator()
        {
            RuleFor(x => x.RoomsNumber)
            .NotNull().WithMessage("RoomsNumber is required.")
            .NotEmpty().WithMessage("RoomsNumber cannot be empty.");

            RuleFor(x => x.Floor)
                .NotNull().WithMessage("Floor is required.")
                .NotEmpty().WithMessage("Floor cannot be empty.");

        }
    }
}
