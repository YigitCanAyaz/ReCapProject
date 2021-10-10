using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.OperationClaimValidator
{
    public class UpdateOperationClaimValidator : AbstractValidator<OperationClaim>
    {
        public UpdateOperationClaimValidator()
        {
            RuleFor(o => o.Id).NotEmpty();

            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
