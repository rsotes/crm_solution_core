using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders.Extensions
{
    public static class OrderItemValidationExtension
    {

        public static void ValidateQuantity(this OrderItem item)
        {
            if (item.Quantity < 1) throw new InvalidDomainException("Quantity is invalid");
        }

        public static void ValidatePrice(this OrderItem item)
        {
            if (item.Price < 0) throw new InvalidDomainException("Price is invalid");
        }
    }
}
