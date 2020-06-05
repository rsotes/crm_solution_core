using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.Extensions
{
    public static class ValidateProductExtension
    {
        public static void ValidateName(this Product product)
        {
            if (string.IsNullOrEmpty(product.Name)) throw new InvalidDomainException("Name is required");
        }

        public static void ValidatePrice(this Product product)
        {
            if (product.Price < 0) throw new InvalidDomainException("Price is invalid");
        }
    }
}
