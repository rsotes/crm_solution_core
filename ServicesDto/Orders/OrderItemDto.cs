using Services.DTOs.Products;

namespace Services.DTOs.Orders
{
    public class OrderItemDto
    {
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public ProductResponseDto Product { get; set; }
    }
}
