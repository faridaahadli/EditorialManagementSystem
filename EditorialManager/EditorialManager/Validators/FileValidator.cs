using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Validators
{
    public class FileValidator: AbstractValidator<IFormFile>
    {
        public FileValidator()
        {
            RuleFor(x => x.Length).NotNull().LessThanOrEqualTo(100)
                .WithMessage("File size is larger than allowed.Allowes size is 100");

            RuleFor(x => x.ContentType).NotNull().Must(x => x.Equals("application/pdf"))
                .WithMessage("Only PDF format supported");

        }
    }
}
