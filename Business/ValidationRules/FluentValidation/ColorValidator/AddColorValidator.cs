using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.ColorValidator
{
    public class AddColorValidator : AbstractValidator<Color>
    {
        public AddColorValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
