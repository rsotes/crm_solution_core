using Infrastructure.Repositories;
using System.Threading.Tasks;
using Services.DTOs.Products;
using MediatR;
using System.Threading;
using Services.DTOs.Products.Extensions;

namespace ServicesQuery.Handler
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryById, CategoryResponseDto>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<CategoryResponseDto> Handle(GetCategoryById request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.FindASync(request.Id);
            if (category == null) return null;
            return category.ToCategoryDto();
        }
    }
}
