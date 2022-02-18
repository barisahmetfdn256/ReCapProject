using Etities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentRules
{
    public class CarimgValiator : AbstractValidator<Carimg>
    {
        public CarimgValiator()
        {
            //RuleFor(img => img.ImagePath).NotEmpty();
        }
    }
}
