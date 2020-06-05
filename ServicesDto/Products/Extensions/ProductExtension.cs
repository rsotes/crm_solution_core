using Domain;
using Domain.Products;
using Services.DTOs;
using Services.DTOs.Products;
using Services.DTOs.Products.Extensions;

namespace Services.Products.Extensions
{
    public static class ProductExtension
    {
        public static ProductResponseDto ToProductDto(this Product product)
        {
            return new ProductResponseDto
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Category = product.Category?.ToCategoryDto()
            };
        }
    }
}
