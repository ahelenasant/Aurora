using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases
{
	public class ManageProductUseCase
	{
		private IProductRepository _productRepository;

		public ManageProductUseCase(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public void Register(Product product)
		{
			_productRepository.Insert(product);
		}

		public void Update(Product product)
		{
			_productRepository.Update(product);
		}

		public void RemoveStockItems(Product product, int value)
		{
			product.RemoveStockItems(value);

			_productRepository.Update(product);
		}

		public void Deactivate(int id)
		{
			var product = Get(id);

			product.Deactivate();

			_productRepository.Update(product);
		}

		public void Activate(int id)
		{
			var product = Get(id);

			product.Activate();

			_productRepository.Update(product);
		}

		private Product Get(int id)
		{
			var product = _productRepository.Get(id);

			if (product is null)
				throw new InvalidOperationException("Produto não encontrado");

			return product;
		}
	}
}
