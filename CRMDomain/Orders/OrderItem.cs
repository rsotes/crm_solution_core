using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Orders.Extensions;

namespace Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; protected set; }

        public int Quantity { get; protected set; }

        public decimal Price { get; protected set; }

        public Product Product { get; protected set; }

        public Order Order { get; protected set; }

        protected internal OrderItem() { }

        public OrderItem(Order order, int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
            Order = order;
            this.ValidateQuantity();
            this.ValidatePrice();
        }
    }
}
