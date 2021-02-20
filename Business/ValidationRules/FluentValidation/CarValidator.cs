using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Araç ismi boş bırakılamaz.");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araç ismi en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Araç günlük fiyat alanı boş bırakılamaz.");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Araç günlük fiyat 0'dan büyük olmalıdır.");
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.BrandId == 1);
            RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araç isimleri A harfi ile başlamalı");
        }
        
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
