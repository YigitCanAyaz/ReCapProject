using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.UserOperationValidator
{
    public class UpdateUserOperationClaimValidator : AbstractValidator<UserOperationClaim>
    {
        public UpdateUserOperationClaimValidator()
        {
            RuleFor(u => u.Id).NotEmpty();

            RuleFor(u => u.UserId).NotEmpty();

            RuleFor(u => u.OperationClaimId).NotEmpty();
        }
    }
}
