using MoonLight.Application.Repositories;
using MoonLight.Domain.Entities;

namespace MoonLight.SqlServerData.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }

        public int Insert(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
