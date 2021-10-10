using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidator
{
    public class DeleteBrandValidator : AbstractValidator<Brand>
    {
        public DeleteBrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
        }
    }
}
