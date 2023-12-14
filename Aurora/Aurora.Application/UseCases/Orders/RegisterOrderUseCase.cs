using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Orders
{
	public class RegisterOrderUseCase
        : IRegisterUseCase<Order>
    {
        private readonly IOrderRepository _orderRepositoy;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IProductRepository _productRepository;

        public RegisterOrderUseCase(IOrderRepository orderRepositoy, IOrderProductRepository orderProductRepository, IProductRepository productRepository)
        {
            _orderRepositoy = orderRepositoy;
            _orderProductRepository = orderProductRepository;
            _productRepository = productRepository;
        }

        public void Execute(Order order)
        {
            order.VerifyProducts();
            order.VerifyCustomer();

            order.CalculatePrice();
            order.UpdateStock();

            var id = _orderRepositoy.Insert(order);

            order.FillOrderProducts(id);

            _orderProductRepository.InsertRange(order.OrderProducts);

            _productRepository.UpdateRange(order.OrderProducts.Select(x => x.Product));
        }
    }
}
