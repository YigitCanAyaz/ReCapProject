using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarValidator
{
    public class UpdateCarValidator : AbstractValidator<Car>
    {
        public UpdateCarValidator()
        {
            RuleFor(c => c.Id).NotEmpty();

            RuleFor(c => c.BrandId).NotEmpty();

            RuleFor(c => c.ColorId).NotEmpty();

            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);

            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(3);

            RuleFor(c => c.ModelYear).NotEmpty();
        }
    }
}
