using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.UserOperationValidator
{
    public class DeleteUserOperationClaimValidator : AbstractValidator<UserOperationClaim>
    {
        public DeleteUserOperationClaimValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
        }
    }
}
