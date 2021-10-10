using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.ColorValidator
{
    public class DeleteColorValidator : AbstractValidator<Color>
    {
        public DeleteColorValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
