using FluentValidation;
using Infrastructure.Repositories;
using MediatR;
using Services.DTOs.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ServicesCommand.Handlers
{
    public class AddCategoryHandler : IPipelineBehavior<AddCategoryCommand, Unit>, IRequestHandler<AddCategoryCommand, Unit> { 
    
        private readonly ICategoryRepository categoryRepository;

        private readonly IEnumerable<IValidator<AddCategoryCommand>> validators;

        public AddCategoryHandler(ICategoryRepository categoryRepository, IEnumerable<IValidator<AddCategoryCommand>> validators)
        {
            this.categoryRepository = categoryRepository;
            this.validators = validators;
        }

        public async Task<Unit> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var context = new FluentValidation.ValidationContext(request);
            var failures = validators
                .Select(x => x.Validate(context))
                .SelectMany(x => x.Errors)
                .Where(x => x != null)
                .ToList();
            if (failures.Count > 0) throw new FluentValidation.ValidationException(failures);

            categoryRepository.Add(new Domain.Products.Category(request.Name));
            return await Task.FromResult<Unit>(Unit.Value);
        }

        public Task<Unit> Handle(AddCategoryCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<Unit> next)
        {
            return next();
        }
    }
}
