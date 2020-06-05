using Infrastructure;
using Infrastructure.Repositories;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace InfraestructureConcrete.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbSet<Product> products;

        public ProductRepository(IUnitOfWork uow)
        {
            products = ((UnitOfWork)uow).Context.Set<Product>();
        }

        public void Add(Product entity)
        {
            products.Add(entity);
        }

        public async Task AddAsync(Product entity)
        {
            await Task.Run(() =>
            {
                products.Add(entity);
            });
            return;
        }

        public void Delete(int id)
        {
            var entity = products.Find(id);
            products.Remove(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await FindASync(id);
            products.Remove(entity);
        }

        public async Task<Product> FindASync(int id)
        {
            return await products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> FindAsync()
        {
            return await products.ToListAsync();
        }

        public async Task<List<Product>> FindAsync(params int[] ids)
        {
            return await products.Where(x => ids.Contains(x.Id)).ToListAsync();
        }

        public IQueryable<Product> AsQueryable()
        {
            return products.AsQueryable();
        }

        public IQueryable<Product> AsQueryableWithCategories()
        {
            return products.AsQueryable().Include(x => x.Category);
        }

        public async Task<IEnumerable<Product>> QueryAsync(int index, int total)
        {
            return await products.AsQueryable().OrderBy(x => x.Id).Skip(index).Take(total).ToListAsync();
        }

        public void Update(Product entity)
        {
            products.Add(entity);
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
