using System;
using System.Threading.Tasks;
using Services.DTOs.Customers;
using System.Collections.Generic;
using MediatR;
using ServicesCommand;
using ServicesQuery;

namespace Services
{
    public class CustomerService
    {
        private readonly IMediator mediator;

        public CustomerService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Add(AddCustomerRequestDto customer)
        {
            // TODO: No domain related validation here
            if (customer.Addresses == null || customer.Addresses.Count == 0) throw new Exception("Address is required");
            
            mediator.Send(new AddCustomerCommand(customer.Name, customer.Phone.PhoneNumber, customer.Phone.Extension, customer.Addresses));
        }

        public async Task<CustomerResponseDto> Find(int id)
        {
            return await mediator.Send(new FindCustomerByIdOrName(id, null));
        }
       
        public async Task<CustomerResponseDto> FindByName(string name)
        {
            return await mediator.Send(new FindCustomerByIdOrName(null, name));
        }

        public async Task<IEnumerable<CustomerResponseDto>> FindAll()
        {
            return await mediator.Send(new FindAllCustomer());
        }
    }
}
