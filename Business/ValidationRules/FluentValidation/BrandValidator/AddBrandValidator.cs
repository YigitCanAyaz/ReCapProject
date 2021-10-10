using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidator
{
    public class AddBrandValidator : AbstractValidator<Brand>
    {
        public AddBrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
        }
    }
}
