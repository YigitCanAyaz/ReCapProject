using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CustomerValidator
{
    public class DeleteCustomerValidator : AbstractValidator<Customer>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
