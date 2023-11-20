using Aurora.Domain.Entities;
using Aurora.Domain.ValueObjects;

namespace Aurora.Application.Repositories
{
	public interface ICustomerRepository
	{
		int Insert(Customer customer);
		int Update(Customer customer);
		Customer Get(int id);
		bool VerifyExistingDocument(Document document);
	}
}
