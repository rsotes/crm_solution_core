using Domain.Products;

namespace Services.DTOs.Products.Extensions
{
    public static class CategoryExtension
    {
        public static CategoryResponseDto ToCategoryDto(this Category category)
        {
            return new CategoryResponseDto
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
