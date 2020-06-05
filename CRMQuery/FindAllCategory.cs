using MediatR;
using Services.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesQuery
{
    public class FindAllCategory : IRequest<IEnumerable<CategoryResponseDto>>
    {
    }
}
