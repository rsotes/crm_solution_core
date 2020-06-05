using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.DTOs.Products
{
    public class ProductResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public CategoryResponseDto Category { get; set; }
    }
}