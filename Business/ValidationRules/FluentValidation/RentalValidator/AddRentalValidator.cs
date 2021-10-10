using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.RentalValidator
{
    public class AddRentalValidator : AbstractValidator<Rental>
    {
        public AddRentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();

            RuleFor(r => r.CustomerId).NotEmpty();
        }
    }
}
