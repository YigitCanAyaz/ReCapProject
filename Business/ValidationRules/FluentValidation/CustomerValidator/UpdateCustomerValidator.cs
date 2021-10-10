using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CustomerValidator
{
    public class UpdateCustomerValidator : AbstractValidator<Customer>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty();

            RuleFor(c => c.UserId).NotEmpty();

            RuleFor(c => c.CompanyName).NotEmpty();
        }
    }
}
