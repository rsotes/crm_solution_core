using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesCommand.Validator
{
    public class AddCategoryValidator : AbstractValidator<AddCategoryCommand>
    {
        public AddCategoryValidator()
        {
            RuleFor(x => x.Name).MaximumLength(10).NotEmpty();
        }
    }
}
