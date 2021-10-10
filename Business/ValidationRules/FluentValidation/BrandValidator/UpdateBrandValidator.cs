using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidator
{
    public class UpdateBrandValidator : AbstractValidator<Brand>
    {
        public UpdateBrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty();

            RuleFor(b => b.Name).NotEmpty();
        }
    }
}
