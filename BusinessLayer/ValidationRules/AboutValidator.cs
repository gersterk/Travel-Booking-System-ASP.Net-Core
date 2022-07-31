using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Cant pass empty");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Cant pass empty");

            RuleFor(X=>X.Description).MinimumLength(50).WithMessage("Description Something");
            RuleFor(X=>X.Description).MaximumLength(1550).WithMessage("Description Something");


        }
    }
}
