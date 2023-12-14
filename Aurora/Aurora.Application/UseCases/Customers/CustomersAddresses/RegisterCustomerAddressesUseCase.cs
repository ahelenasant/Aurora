using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Customers.CustomersAddresses
{
	public class RegisterCustomerAddressesUseCase
		: IRegisterUseCase<IEnumerable<CustomerAddress>>
	{
		private readonly ICustomerAddressRepository _customerAddressRepository;

		public RegisterCustomerAddressesUseCase(ICustomerAddressRepository customerAddressRepository)
		{
			_customerAddressRepository = customerAddressRepository;
		}

		public void Execute(IEnumerable<CustomerAddress> addresses)
		{
			_customerAddressRepository.InsertRange(addresses);
		}
	}
}
