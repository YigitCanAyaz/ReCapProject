using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.OperationClaimValidator
{
    public class DeleteOperationClaimValidator : AbstractValidator<OperationClaim>
    {
        public DeleteOperationClaimValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
        }
    }
}
