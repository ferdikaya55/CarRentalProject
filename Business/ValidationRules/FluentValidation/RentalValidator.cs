using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(re => re.CarId).NotEmpty().WithMessage("Alan boş bırakılamaz.");
            RuleFor(re => re.CustomerId).NotEmpty().WithMessage("Alan boş bırakılamaz.");
            RuleFor(re => re.RentDate).NotEmpty().WithMessage("Alan boş bırakılamaz.");
        }
    }
}
