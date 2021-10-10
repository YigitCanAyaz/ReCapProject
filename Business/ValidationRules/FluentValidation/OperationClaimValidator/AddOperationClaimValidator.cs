using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.OperationClaimValidator
{
    public class AddOperationClaimValidator : AbstractValidator<OperationClaim>
    {
        public AddOperationClaimValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
