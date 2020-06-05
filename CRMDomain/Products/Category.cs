using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products.Extensions;

namespace Domain.Products
{
    public class Category
    {
        // TODO: NOOOOOOOO public setter
        public int Id { get; set; }
        // TODO: NOOOOOOOO public setter
        public string Name { get; set; }
        
        // TODO: Change this name to: InternalProducts (mappings need to be modified also)
        protected ICollection<Product> Products { get; private set; }

        public IReadOnlyCollection<Product> ReadProducts { get; }

        protected internal Category()
        {
        }

        public Category(string name)
        {
            // TODO: Try to use another validation method here
            Name = name;
            this.ValidateName();
        }
    }
}
