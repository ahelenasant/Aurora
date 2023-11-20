using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface ICustomerAddressRepository
	{
		CustomerAddress Get(int id);
		void InsertRange(List<CustomerAddress> addresses);
		void UpdateRange(CustomerAddress address);
	}
}
