using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.Exceptions
{
    public class InvalidDomainException : Exception
    {
        public InvalidDomainException() : base() { }

        public InvalidDomainException(string message) : base(message) { }

        public InvalidDomainException(string message, Exception innerException) : base(message, innerException) { }
    }
}
