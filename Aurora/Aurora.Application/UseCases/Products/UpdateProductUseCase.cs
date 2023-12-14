using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Products
{
	public class UpdateProductUseCase
		: IUpdateUseCase<Product>
	{
		private readonly IProductRepository _productRepository;

		public UpdateProductUseCase(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public void Execute(Product product)
		{
			_productRepository.Update(product);
		}
	}
}
