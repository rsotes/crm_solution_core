using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Domain.Customers;
using Domain.Orders.Extensions;

namespace Domain.Orders
{
    public class Order
    {
        public int OrderId { get; protected set; }

        public string OrderNumber { get; protected set; }

        public decimal Total { 
            get {
                return Items.Sum(x => x.Price);
            } 
        }

        public Customer Customer { get; protected set; }

        public ICollection<OrderItem> Items { get; protected set; }

        protected internal Order(){ }

        public Order(Customer customer, ICollection<OrderItem> items)
        {
            Customer = customer;
            Items = items;
            this.ValidateCustomer();
            this.ValidateOrderItems();
        }
    }
}
