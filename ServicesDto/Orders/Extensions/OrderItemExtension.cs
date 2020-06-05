using Domain.Orders;
using Services.DTOs.Orders;
using Services.Products.Extensions;

namespace Services.extensions
{
    public static class OrderItemExtension
    {
        public static OrderItemDto ToOrderItemDto(this OrderItem orderItem)
        {
            return new OrderItemDto
            {
                Price = orderItem.Price,
                Product = orderItem.Product.ToProductDto(),
                Quantity = orderItem.Quantity
            };
        }
    }
}
