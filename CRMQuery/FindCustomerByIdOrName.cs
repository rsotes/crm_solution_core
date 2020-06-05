using MediatR;
using Services.DTOs.Customers;

namespace ServicesQuery
{
    public class FindCustomerByIdOrName :IRequest<CustomerResponseDto>
    {
        public int? Id { get; protected set; }

        public string Name { get; protected set; }

        public FindCustomerByIdOrName(int? id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
