using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarImageValidator
{
    public class AddCarImageValidator : AbstractValidator<CarImage>
    {
        public AddCarImageValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}
