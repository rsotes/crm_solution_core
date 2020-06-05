using Domain;
using Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ICustomerRepository : IRepositoryRead<Customer>, IRepositoryWrite<Customer>
    {

        public Task<Customer> FindByName(string name);
    }
}
