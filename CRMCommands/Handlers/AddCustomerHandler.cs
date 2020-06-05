using Domain.Customers;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ServicesCommand.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, Unit>
    {
        private readonly ICustomerRepository customerRepository;

        public AddCustomerHandler(ICustomerRepository cRepository)
        {
            customerRepository = cRepository;
        }

        public Task<Unit> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var addresses = request.Addresses.Select(x => new Address(x.Street, x.City, x.State, x.Country, x.PostalCode)).ToList();
            customerRepository.Add(new Customer(request.Name, addresses));
            return Task.FromResult(Unit.Value);
        }
    }
}
