using Infrastructure;
using Infrastructure.Repositories;
using Domain;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureConcrete.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbSet<Order> orders;

        public OrderRepository(IUnitOfWork uow)
        {
            orders = ((UnitOfWork)uow).Context.Set<Order>();
        }

        public void Add(Order entity)
        {
            orders.Add(entity);
        }

        public Task AddAsync(Order entity)
        {
            return null;
        }

        public void Delete(int id)
        {
            var entity = orders.Find(id);
            if (entity == null) throw new Exception("Entity not found");
            orders.Remove(entity);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> FindASync(int id)
        {
            return await orders.FindAsync(id);
        }

        public async Task<IEnumerable<Order>> FindAsync()
        {
            return await orders.ToListAsync();
        }

        public IQueryable<Order> AsQueryable()
        {
            return orders.AsQueryable();
        }

        public async Task<IEnumerable<Order>> QueryAsync(int index, int total)
        {
            return await orders.AsQueryable().OrderBy(x => x.OrderId).Skip(index).Take(total).ToListAsync();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
