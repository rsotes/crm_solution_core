using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRepositoryWrite<T>
    {
        void Add(T entity);

        Task AddAsync(T entity);

        void Delete(int id);

        Task DeleteAsync(int id);

        void Update(T entity);

        Task UpdateAsync(T entity);

    }
}
