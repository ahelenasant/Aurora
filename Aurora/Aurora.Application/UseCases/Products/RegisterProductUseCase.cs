using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Products
{
	public class RegisterProductUseCase
        : IRegisterUseCase<Product>
    {
        private readonly IProductRepository _productRepository;

        public RegisterProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            _productRepository.Insert(product);
        }
    }
}
