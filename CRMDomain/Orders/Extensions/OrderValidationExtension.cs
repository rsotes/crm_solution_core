using Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders.Extensions
{
    public static class OrderValidationExtension
    {
        public static void ValidateOrderItems(this Order order)
        {
            if (order.Items == null || order.Items.Count == 0) throw new InvalidDomainException("Items are required");
        }

        public static void ValidateCustomer(this Order order)
        {
            if (order.Customer == null) throw new InvalidDomainException("Customer is required");
        }
    }
}
