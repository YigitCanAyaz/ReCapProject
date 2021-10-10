using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarValidator
{
    public class DeleteCarValidator : AbstractValidator<Car>
    {
        public DeleteCarValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
