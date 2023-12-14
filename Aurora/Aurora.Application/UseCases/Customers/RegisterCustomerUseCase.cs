using Aurora.Application.Interfaces;
using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases.Customers
{
	public class RegisterCustomerUseCase
		: IRegisterUseCase<Customer>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IRegisterUseCase<IEnumerable<CustomerAddress>> _registerCustomerAddressesUseCase;

		public RegisterCustomerUseCase(ICustomerRepository customerRepository, IRegisterUseCase<IEnumerable<CustomerAddress>> registerCustomerAddressesUseCase)
		{
			_customerRepository = customerRepository;
			_registerCustomerAddressesUseCase = registerCustomerAddressesUseCase;
		}

		public void Execute(Customer customer)
		{
			if (_customerRepository.VerifyExistingDocument(customer.Document))
				throw new InvalidOperationException("O cliente já possui cadastro!");

			var id = _customerRepository.Insert(customer);

			customer.FillInAddress(id);

			_registerCustomerAddressesUseCase.Execute(customer.Addresses);
		}
	}
}
