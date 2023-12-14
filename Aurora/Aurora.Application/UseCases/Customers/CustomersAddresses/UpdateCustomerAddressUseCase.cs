using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Customers.CustomersAddresses
{
	public class UpdateCustomerAddressUseCase
		: IUpdateUseCase<IEnumerable<CustomerAddress>>
	{
		private readonly ICustomerAddressRepository _customerAddressRepository;

		public UpdateCustomerAddressUseCase(ICustomerAddressRepository customerAddressRepository)
		{
			_customerAddressRepository = customerAddressRepository;
		}

		public void Execute(IEnumerable<CustomerAddress> customerAddress)
		{
			_customerAddressRepository.UpdateRange(customerAddress);
		}
	}
}
