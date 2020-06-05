using Infrastructure;
using Infrastructure.Repositories;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureConcrete.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbSet<Category> categories;

        public CategoryRepository(IUnitOfWork uow)
        {
            categories = ((UnitOfWork)uow).Context.Set<Category>();
        }

        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public async Task AddAsync(Category entity)
        {
            await Task.Run(() => {
                categories.Add(entity);
            });
            return;
        }

        public IQueryable<Category> AsQueryable()
        {
            return categories.AsQueryable();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> FindASync(int id)
        {
            return await categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> FindAsync()
        {
            return await categories.ToListAsync();
        }

        public async Task<IEnumerable<Category>> QueryAsync(int index, int total)
        {
            return await categories.AsQueryable().OrderBy(x => x.Id).Skip(index).Take(total).ToListAsync();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }

    }
}
