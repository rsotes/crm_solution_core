using Infrastructure.Repositories;
using MediatR;
using Services.DTOs.Customers;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Services.DTOs.Customers.Extensions;

namespace ServicesQuery.Handler
{
    public class FindAllCustomerHandler : IRequestHandler<FindAllCustomer, IEnumerable<CustomerResponseDto>>
    {
        private readonly ICustomerRepository customerRepository;

        public FindAllCustomerHandler(ICustomerRepository crepository)
        {
            customerRepository = crepository;
        }

        public async Task<IEnumerable<CustomerResponseDto>> Handle(FindAllCustomer request, CancellationToken cancellationToken)
        {
            var customers = await customerRepository.FindAsync();
            return customers.Select(x => x.ToCustomerDto()).ToList();
        }
    }
}
