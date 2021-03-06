using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarImageValidator
{
    public class UpdateCarImageValidator : AbstractValidator<CarImage>
    {
        public UpdateCarImageValidator()
        {
            RuleFor(c => c.Id).NotEmpty();

            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}
