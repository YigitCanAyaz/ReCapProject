using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.UserValidator
{
    public class DeleteUserValidator : AbstractValidator<User>
    {
        public DeleteUserValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
        }
    }
}
