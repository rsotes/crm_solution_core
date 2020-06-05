using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Customers.Extensions;

namespace Domain.Customers
{
    public class Address
    {
        public int Id { get; protected set; }

        public string Street { get; protected set; }
        
        public string City { get; protected set; }

        public string State { get; protected set; }

        public string Country { get; protected set; }

        public string PostalCode { get; protected set; }

        protected internal Address() { }

        public Address(string street, string city, string state, string country, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
            this.ValidateAddress();
        }
    }
}
