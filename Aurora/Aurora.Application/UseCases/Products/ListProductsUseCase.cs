using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Products
{
    public class ListProductsUseCase
		: IListUseCase<Product>
	{
		private readonly IProductRepository _productRepository;

		public ListProductsUseCase(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public IEnumerable<Product> Execute()
		{
			//var products = _productRepository.Get();

			var products = getproducts();

			return products;
		}

		private IEnumerable<Product> getproducts()
		{
			for (var i = 0; i < 5; i++)
			{
				yield return new Product($"Teste {i}", i * 10.00, i * 100, DateTime.Now, true);
			}
		}
	}
}
