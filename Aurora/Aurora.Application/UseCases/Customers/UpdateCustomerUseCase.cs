using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Customers
{
	public class UpdateCustomerUseCase
		: IUpdateUseCase<Customer>
	{
		private readonly ICustomerRepository _customerRepository;

		public UpdateCustomerUseCase(ICustomerRepository customerRepository, IRegisterUseCase<IEnumerable<CustomerAddress>> registerCustomerAddressesUseCase)
		{
			_customerRepository = customerRepository;
		}

		public void Execute(Customer customer)
		{
			_customerRepository.Update(customer);
		}
	}
}
