using Domain;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IOrderRepository : IRepositoryRead<Order>, IRepositoryWrite<Order>
    {
    }
}
