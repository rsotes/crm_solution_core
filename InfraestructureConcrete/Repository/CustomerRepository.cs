using Infrastructure;
using Infrastructure.Repositories;
using Domain;
using Domain.Customers;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureConcrete.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DbSet<Customer> customers;

        public CustomerRepository(IUnitOfWork uow)
        {
            customers = ((UnitOfWork)uow).Context.Set<Customer>();
        }

        public void Add(Customer entity)
        {
            customers.Add(entity);
        }

        public Task AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async void Delete(int id)
        {
            var entity = await customers.FindAsync(id);
            if (entity == null) throw new Exception("Customer not found");
            customers.Remove(entity);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> FindASync(int id)
        {
            return await customers.FindAsync(id);
        }

        public async Task<Customer> FindByName(string name)
        {
            return await customers.Where(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Customer>> FindAsync()
        {
            return await customers.ToListAsync();
        }

        public IQueryable<Customer> AsQueryable()
        {
            return customers.AsQueryable();
        }

        public async Task<IEnumerable<Customer>> QueryAsync(int index, int total)
        {
            return await customers.AsQueryable().OrderBy(x => x.CustomerId).Skip(index).Take(total).ToListAsync();
        }

        public void Update(Customer entity)
        {
            throw new Exception();
        }

        public Task UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
