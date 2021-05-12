using App.Core.Services;
using EditorialManager.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Validators
{
    public class UserValidator:AbstractValidator<UserInsertDto>
    {
       


        public UserValidator()
        {
           
            RuleFor(x => x.Email)
                .NotNull().WithMessage("This field is required")
                .EmailAddress().WithMessage("Please enter email format");
              
            RuleFor(x => x.FirstName)
                .NotNull().WithMessage("This field is required")
                .MaximumLength(50);
            RuleFor(x => x.LastName)
               .NotNull().WithMessage("This field is required")
               .MaximumLength(50);         
            RuleFor(x => x.Title)
                .NotNull().WithMessage("This field is required")
                .MaximumLength(50);
            RuleFor(x => x.PasswordHash).
                PasswordChecker();
            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.PasswordHash).WithMessage("Passwords don't match");
           
        }
    }
}
