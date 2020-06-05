using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers.Extensions
{
    public static class AddressValidationExtension
    {
        public static void ValidateAddress(this Address address)
        {
            if (string.IsNullOrEmpty(address.Street)) throw new InvalidDomainException("Street is required");
            if (string.IsNullOrEmpty(address.City)) throw new InvalidDomainException("City is required");
            if (string.IsNullOrEmpty(address.Country)) throw new InvalidDomainException("Country is required");
            if (string.IsNullOrEmpty(address.PostalCode)) throw new InvalidDomainException("Postal code is required");
        }
    }
}
