using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions
{
    public class CategoryRequiredException : Exception
    {
        public CategoryRequiredException() : base() { }

        public CategoryRequiredException(string message) : base(message) { }

        public CategoryRequiredException(string message, Exception innerException) : base(message, innerException) { }

    }
}
