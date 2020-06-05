using Infrastructure.Repositories;
using MediatR;
using Services.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Services.DTOs.Products.Extensions;

namespace ServicesQuery.Handler
{
    public class FindAllCategoryHandler : IRequestHandler<FindAllCategory, IEnumerable<CategoryResponseDto>>
    {
        private readonly ICategoryRepository categoryRepository;

        public FindAllCategoryHandler(ICategoryRepository crepository)
        {
            categoryRepository = crepository;
        }

        public async Task<IEnumerable<CategoryResponseDto>> Handle(FindAllCategory request, CancellationToken cancellationToken)
        {
            var categories = await categoryRepository.FindAsync();
            return categories.Select(y => y.ToCategoryDto()).ToList();
        }
    }
}
