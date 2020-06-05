using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.Exceptions
{
    public class DomainNotFoundException : Exception
    {
        public DomainNotFoundException()
        {
        }

        public DomainNotFoundException(string message) : base(message)
        {
        }

        public DomainNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
