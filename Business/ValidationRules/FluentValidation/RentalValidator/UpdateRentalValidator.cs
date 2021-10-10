using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.RentalValidator
{
    public class UpdateRentalValidator : AbstractValidator<Rental>
    {
        public UpdateRentalValidator()
        {
            RuleFor(r => r.Id).NotEmpty();

            RuleFor(r => r.CarId).NotEmpty();

            RuleFor(r => r.CustomerId).NotEmpty();
        }
    }
}
