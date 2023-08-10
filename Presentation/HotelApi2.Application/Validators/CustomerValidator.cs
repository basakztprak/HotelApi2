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
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName)
                .NotEmpty().WithMessage("Customer name is required");

            RuleFor(x => x.CustomerSurname)
                .NotEmpty().WithMessage("Customer surname is required");

            RuleFor(x => x.CustomerPhoneNumber)
                .NotEmpty().WithMessage("Customer phone number can not be empty");
        }
    }
}
