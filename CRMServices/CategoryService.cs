using Services.DTOs.Products;
using System.Threading.Tasks;
using Services.DTOs.Products.Extensions;
using ServicesCommand;
using ServicesCommand.Handlers;
using ServicesQuery;
using ServicesQuery.Handler;
using MediatR;
using System.Collections.Generic;

namespace Services
{
    public class CategoryService
    {
        private readonly IMediator mediator;

        public CategoryService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IEnumerable<CategoryResponseDto>> FindAllASync()
        {
            return await mediator.Send(new FindAllCategory());
        }

        public async Task<CategoryResponseDto> FindAsync(int id)
        {
            return await mediator.Send(new GetCategoryById(id));
        }

        public async void AddCategory(AddCategoryDto dto)
        {
            await mediator.Send(new AddCategoryCommand { Name = dto.Name });
        }
    }
}
