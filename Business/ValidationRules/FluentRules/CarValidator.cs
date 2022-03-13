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
            RuleFor(c => c.DailyPrice).LessThan(7000);
            RuleFor(c=> c.DailyPrice).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(1999);
            


        }
 

    }
}
