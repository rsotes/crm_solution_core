using System.Collections.Generic;

namespace Services.DTOs.Orders
{
    public class AddOrderRequest
    {
        public int CustomerId { get; set; }

        public List<OrderItemDto> Items { get; set; }
    }
}
