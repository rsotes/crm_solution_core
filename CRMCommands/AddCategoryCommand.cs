using MediatR;
using Services.DTOs.Products;

namespace ServicesCommand
{
    public class AddCategoryCommand : IRequest<Unit>
    {
        public string Name { get; set; }
    }
}
