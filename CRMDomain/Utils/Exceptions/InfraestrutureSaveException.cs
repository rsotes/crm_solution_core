using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.Exceptions
{
    public class InfraestrutureSaveException : Exception
    {
        public InfraestrutureSaveException()
        {
        }

        public InfraestrutureSaveException(string message) : base(message)
        {
        }

        public InfraestrutureSaveException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
