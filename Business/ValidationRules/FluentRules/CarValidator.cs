using Etities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(500);
            RuleFor(c => c.DailyPrice).LessThan(10000);
            RuleFor(c=> c.DailyPrice).NotEmpty();
            


        }
 

    }
}
