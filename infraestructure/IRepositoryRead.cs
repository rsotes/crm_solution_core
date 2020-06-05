using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRepositoryRead<T>
    {
        Task<IEnumerable<T>> QueryAsync(int index, int total);

        IQueryable<T> AsQueryable();

        Task<T> FindASync(int id);

        Task<IEnumerable<T>> FindAsync();

    }
}
