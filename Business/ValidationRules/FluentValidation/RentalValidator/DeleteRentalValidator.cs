using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.RentalValidator
{
    public class DeleteRentalValidator : AbstractValidator<Rental>
    {
        public DeleteRentalValidator()
        {
            RuleFor(r => r.Id).NotEmpty();
        }
    }
}
