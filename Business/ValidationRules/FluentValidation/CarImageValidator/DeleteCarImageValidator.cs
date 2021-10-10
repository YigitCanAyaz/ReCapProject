using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarImageValidator
{
    public class DeleteCarImageValidator : AbstractValidator<CarImage>
    {
        public DeleteCarImageValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
