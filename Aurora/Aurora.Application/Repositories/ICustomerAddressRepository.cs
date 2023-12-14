using Aurora.Domain.Entities;

namespace Aurora.Application.Repositories
{
	public interface ICustomerAddressRepository
	{
		CustomerAddress Get(int id);
		void InsertRange(IEnumerable<CustomerAddress> addresses);
		void UpdateRange(IEnumerable<CustomerAddress> customerAddress);
	}
}
