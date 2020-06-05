using Domain;
using Domain.Customers;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureConcrete.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasMany<OrderItem>(x => x.Items)
                .WithRequired(x => x.Order);

            HasRequired(x => x.Customer);

            Ignore(x => x.Total);
            
        }
    }
}
