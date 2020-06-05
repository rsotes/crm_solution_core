using Domain;
using Domain.Customers;
using Domain.Orders;
using System.Data.Entity.ModelConfiguration;

namespace InfraestructureConcrete.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasMany(x => x.Orders);

            HasMany(x => x.Addresses);

            Property(x => x.Name).IsRequired().HasMaxLength(100);

            Property(x => x.PhoneNumber).HasMaxLength(8);

        }
    }
}
