using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Orders
{
	public class ListOrderUseCase
		: IListUseCase<Order>
	{
		private readonly IOrderRepository _orderRepositoy;

		public ListOrderUseCase(IOrderRepository orderRepositoy)
		{
			_orderRepositoy = orderRepositoy;
		}

		public IEnumerable<Order> Execute()
		{
			return _orderRepositoy.Get();
		}
	}
}
