using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface IOrderProductRepository
	{
		void InsertRange(List<OrderProduct> orderProducts);
	}
}
