using Domain.Orders;
using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Domain.Customers.Extensions;

namespace Domain.Customers
{
    public class Customer
    {
        public int CustomerId { get; protected set; }

        public string Name { get; protected set; }

        public ICollection<Order> Orders { get; protected set; }

        public ICollection<Address> Addresses { get; protected set; }

        public string PhoneNumber { get; protected set; }

        public string Extension { get; protected set; }

        protected internal Customer() { }

        public Customer(string name, ICollection<Address> addresses)
        {
            Name = name;
            Addresses = addresses;
            this.ValidateName();
        }

        public Customer(string name, ICollection<Address> addresses, string phoneNumber)
        {
            Name = name;
            Addresses = addresses.Select(x => new Address(x.Street, x.City, x.State, x.Country, x.PostalCode)).ToList();
            PhoneNumber = phoneNumber;
            this.ValidateName();
            this.ValidateAddress();
            this.ValidatePhoneNumber();
        }


        public Customer(string name, ICollection<Address> addresses, string phoneNumber, string extension)
        {
            Name = name;
            Addresses = addresses;
            PhoneNumber = phoneNumber;
            Extension = extension;
            this.ValidateName();
            this.ValidateAddress();
            this.ValidatePhoneNumber();
            this.ValidatePhoneExtension();

        }

        public Customer(string name, ICollection<Address> addresses, ICollection<Order> orders)
        {
            Name = name;
            Orders = orders;
            this.ValidateName();
            this.ValidateAddress();
        }

        public Customer(string name, ICollection<Address> addresses, ICollection<Order> orders, string phoneNumber)
        {
            Name = name;
            Addresses = addresses;
            PhoneNumber = phoneNumber;
            Orders = orders;
            this.ValidateName();
            this.ValidateAddress();
            this.ValidatePhoneNumber();
        }

        public Customer(string name, ICollection<Address> addresses, ICollection<Order> orders, string phoneNumber, string extension)
        {
            Name = name;
            Addresses = addresses;
            Orders = orders;
            PhoneNumber = phoneNumber;
            Extension = extension;
            this.ValidateName();
            this.ValidateAddress();
            this.ValidatePhoneNumber();
            this.ValidatePhoneExtension();
        }
    }
}
