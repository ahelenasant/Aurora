using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases
{
	public class ManageCustomerAddressUseCase
	{
		private ICustomerAddressRepository _customerAddressRepository;

		public ManageCustomerAddressUseCase(ICustomerAddressRepository customerAddressRepository)
		{
			_customerAddressRepository = customerAddressRepository;
		}

		public void Register(List<CustomerAddress> addresses)
		{
			_customerAddressRepository.InsertRange(addresses);
		}

		public void Update(CustomerAddress address)
		{

			_customerAddressRepository.UpdateRange(address);
		}

		public CustomerAddress Get(int id)
		{
			var address = _customerAddressRepository.Get(id);

			if (address is null)
				throw new InvalidOperationException("Cliente não encontrado");

			return address;
		}
	}
}
