using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.UserValidator
{
    public class AddUserValidator : AbstractValidator<User>
    {
        public AddUserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();

            RuleFor(u => u.LastName).NotEmpty();

            RuleFor(u => u.Email).NotEmpty();

            RuleFor(u => u.PasswordHash).NotEmpty();

            RuleFor(u => u.PasswordSalt).NotEmpty();

            RuleFor(u => u.Status).NotEmpty();
        }
    }
}
