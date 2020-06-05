using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException() : base() { }

        public CategoryNotFoundException(string message) : base(message) { }

        public CategoryNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    }
}
