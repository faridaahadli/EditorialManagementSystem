using EditorialManager.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Validators
{
    public class UploadArticleValidator: AbstractValidator<ArticleInsDto>
    {
        public UploadArticleValidator()
        {
            //RuleFor(x => x.ArticleFile).SetValidator(new FileValidator());
            RuleFor(x => x.ArticleFile)
                .Must(p => p.ContentType == "application/pdf").WithMessage("Only PDF format supported")
                .Must(p => p.Length<=1024*1024*30).WithMessage("File size is greater than allowed");
                
        }
    }
}
