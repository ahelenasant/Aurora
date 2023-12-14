using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface IProductRepository
	{
		Product Get(int id);
		IEnumerable<Product> Get();
		void Insert(Product product);
		void Update(Product product);
		void UpdateRange(IEnumerable<Product> enumerable);
	}
}
