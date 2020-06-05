using InfraestructureConcrete.Configurations;
using Infrastructure;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureConcrete
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext() : base("ProductsDB")
        {
            Database.SetInitializer<ProductsDBContext>(new CreateDatabaseIfNotExists<ProductsDBContext>());              
        }

        //public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderItemConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
