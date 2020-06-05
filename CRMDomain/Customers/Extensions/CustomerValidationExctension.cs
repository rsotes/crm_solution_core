using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers.Extensions
{
    public static class CustomerValidationExctension
    {
        public static void ValidateName(this Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name)) throw new InvalidDomainException("Name is required");
        }

        public static void ValidateAddress(this Customer customer)
        {
            if (customer.Addresses.Count == 0) throw new InvalidDomainException("Address is required");
        }

        public static void ValidatePhoneNumber(this Customer customer)
        {
            if (string.IsNullOrEmpty(customer.PhoneNumber)) throw new InvalidDomainException("Phone number is required");
            if (customer.PhoneNumber.Length > 8) throw new InvalidDomainException("Phone number is too long");
        }

        public static void ValidatePhoneExtension(this Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Extension)) throw new InvalidDomainException("Phone extension is required");
            if (customer.Extension.Length > 3) throw new InvalidDomainException("Phone extension is too long");
        }

    }
}
