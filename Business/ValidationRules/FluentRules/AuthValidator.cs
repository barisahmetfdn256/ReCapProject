using Core.Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentRules
{
    public class AuthValidator : AbstractValidator<User>
    {
        public AuthValidator()
        {
            RuleFor(u => u.FirstName.Length).GreaterThan(2).WithMessage("En az 3 kelime"); 
            RuleFor(u => u.FirstName.Length).LessThan(9).WithMessage("En fazla 9 kelime");

            RuleFor(u => u.LastName.Length).GreaterThan(2).WithMessage("En az 2 kelime"); 
            RuleFor(u => u.LastName.Length).LessThan(9).WithMessage("En fazla 9 kelime");




           

        
        }


    }
}
