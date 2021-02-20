using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Alan boş bırakılamaz.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Alan boş bırakılamaz.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Alan boş bırakılamaz.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Alan boş bırakılamaz.");
        }
    }
}
