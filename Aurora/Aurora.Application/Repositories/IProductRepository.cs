using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface IProductRepository
	{
		Product Get(int id);
		void Insert(Product product);
		void Update(Product product);
	}
}
