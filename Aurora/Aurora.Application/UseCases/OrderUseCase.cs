using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases
{
	public class OrderUseCase
	{
		private IOrderRepositoy _orderRepositoy;


		public void Execute(Order order)
		{
			order.UpdateStock();

			order.CalculatePrice();

			var id = _orderRepositoy.Insert(order);

			order.FillOrderProducts(id);
		}
	}
}
