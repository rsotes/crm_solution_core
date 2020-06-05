using Domain.Products.Extensions;

namespace Domain.Products
{
    public class Product
    {
        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public decimal Price { get; protected set; }
        
        public string Description { get; protected set; }

        public bool Enabled { get; protected set; }

        public Category Category { get; protected set; }

        protected internal Product()
        {
        }

        public Product(string name, string description, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
            Description = description;
            Enabled = true;
            this.ValidateName();
            this.ValidatePrice();            
        }
    }
}
