using MediatR;
using Services.DTOs;
using System.Collections.Generic;

namespace ServicesCommand
{
    public class AddCustomerCommand : IRequest<Unit>
    {
        public string Name { get; }

        public string PhoneNumber { get; }

        public string PhoneExtension { get; }

        public ICollection<AddressDto> Addresses { get; }

        public AddCustomerCommand(string name, string phoneNumber, string phoneExtension, ICollection<AddressDto> addresses)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PhoneExtension = phoneExtension;
            Addresses = addresses;
        }
    }
}
