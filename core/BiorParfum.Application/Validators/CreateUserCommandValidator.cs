using BiorParfum.Application.Extentions;
using BiorParfum.Application.Features.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Validators
{
    public class CreateUserCommandValidator: AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Email)
                    .NotEmpty()
                    .CheckNull();

            RuleFor(x => x.FirstName)
                     .NotEmpty()
                     .CheckNull();

            RuleFor(x => x.LastName)
                     .NotEmpty()
                     .CheckNull();


            RuleFor(x => x.Password)
                     .NotEmpty()
                     .CheckNull();
        }
    }
}
