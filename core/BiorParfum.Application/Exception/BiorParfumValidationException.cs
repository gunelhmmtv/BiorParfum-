using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Exception
{
    public class BiorParfumValidationException : ApplicationException
    {

        public List<ValidationFailure> ValidationFailures { get; set; }
        public BiorParfumValidationException(List<ValidationFailure> validationFailures)
            : base("Validation Exception")
        {
            ValidationFailures = validationFailures;
        }
    }
}
