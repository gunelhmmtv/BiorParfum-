using BiorParfum.Application.Features.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Validators
{
    public class AddProductCommandValidator : AbstractValidator<AddProductsCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Product Name cannot be empty");
            RuleFor(x=>x.Description)
                .NotEmpty().WithMessage("Description cannot be empty");
            RuleFor(x => x.Weight)
                .NotEmpty();
            RuleFor(x=>x.Price)
                .NotNull();
            RuleFor(x=>x.CategoryId)
                .NotEmpty();
        }
    }
}
