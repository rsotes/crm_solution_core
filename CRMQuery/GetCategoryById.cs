using MediatR;
using Services.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesQuery
{
    public class GetCategoryById : IRequest<CategoryResponseDto>
    {
        public int Id { get; set; }

        public GetCategoryById(int id)
        {
            this.Id = id;
        }
    }
}
