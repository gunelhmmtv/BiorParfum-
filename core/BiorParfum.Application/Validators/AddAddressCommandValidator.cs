using BiorParfum.Application.Features.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Validators
{
    public class AddAddressCommandValidator : AbstractValidator<AddAddressCommand>
    {
        public AddAddressCommandValidator()
        {
            RuleFor(x=>x.CityName)
                .NotEmpty().WithMessage("City Name cannot be empty");
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("Street cannot be empty");
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("Country cannot be empty");
        }
    }
}
