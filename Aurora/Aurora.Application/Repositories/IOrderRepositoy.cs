using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface IOrderRepositoy
	{
		int Insert(Order order);
	}
}
