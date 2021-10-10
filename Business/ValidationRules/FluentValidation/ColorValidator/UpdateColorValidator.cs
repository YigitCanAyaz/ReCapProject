using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.ColorValidator
{
    public class UpdateColorValidator : AbstractValidator<Color>
    {
        public UpdateColorValidator()
        {
            RuleFor(c => c.Id).NotEmpty();

            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
