using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CustomerValidator
{
    public class AddCustomerValidator : AbstractValidator<Customer>
    {
        public AddCustomerValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();

            RuleFor(c => c.CompanyName).NotEmpty();
        }
    }
}
