using Domain;
using Domain.Orders;
using Services.DTOs;
using Services.DTOs.Orders;
using System.Linq;

namespace Services.extensions
{
    public static class OrderExtension
    {
        public static OrderResponse ToOrderDto(this Order order)
        {
            return new OrderResponse
            {
                Id = order.OrderId,
                Items = order.Items.Select(x => x.ToOrderItemDto()).ToList()
            };
        }
    }
}
