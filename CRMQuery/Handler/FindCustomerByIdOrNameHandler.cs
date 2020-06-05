using Domain.Customers;
using Infrastructure.Repositories;
using MediatR;
using Services.DTOs.Customers;
using System.Threading;
using System.Threading.Tasks;
using Services.DTOs.Customers.Extensions;

namespace ServicesQuery.Handler
{
    public class FindCustomerByIdOrNameHandler : IRequestHandler<FindCustomerByIdOrName, CustomerResponseDto>
    {
        private readonly ICustomerRepository customerRepository;

        public FindCustomerByIdOrNameHandler(ICustomerRepository crepository)
        {
            customerRepository = crepository;
        }

        public async Task<CustomerResponseDto> Handle(FindCustomerByIdOrName request, CancellationToken cancellationToken)
        {
            Customer customer = null;
            if (request.Id != null) customer = await customerRepository.FindASync(request.Id.Value);
            else if (request.Name == null || request.Name.Length == 0) customer = await customerRepository.FindByName(request.Name);
            return customer.ToCustomerDto();
        }
    }
}
