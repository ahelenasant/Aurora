using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface IOrderRepository
	{
		IEnumerable<Order> Get();
		int Insert(Order order);
	}
}
