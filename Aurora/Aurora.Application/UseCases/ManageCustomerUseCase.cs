using Aurora.Application.Repositories;
using Aurora.Domain.Entities;

namespace Aurora.Application.UseCases
{
	public class ManageCustomerUseCase
	{
		private ICustomerRepository _customerRepository;
		private ManageCustomerAddressUseCase _manageCustomerAddressUseCase;

		public ManageCustomerUseCase(ICustomerRepository customerRepository, ManageCustomerAddressUseCase manageCustomerAddressUseCase)
		{
			_customerRepository = customerRepository;
			_manageCustomerAddressUseCase = manageCustomerAddressUseCase;
		}

		public void Register(Customer customer)
		{
			if (_customerRepository.VerifyExistingDocument(customer.Document))
				throw new InvalidOperationException("O cliente já possui cadastro!");

			var id = _customerRepository.Insert(customer);

			customer.FillInAddress(id);

			_manageCustomerAddressUseCase.Register(customer.Addresses);
		}

		public void Update(Customer customer)
		{
			Get(customer.Id);

			var id = _customerRepository.Update(customer);

			customer.FillInAddress(id);
		}

		public Customer Get(int id)
		{
			var customer = _customerRepository.Get(id);

			if (customer is null)
				throw new InvalidOperationException("Cliente não encontrado");

			return customer;
		}

		public void Deactivate(int id)
		{
			var customer = Get(id);

			customer.Deactivate();

			_customerRepository.Update(customer);
		}

		public void Activate(int id)
		{
			var customer = Get(id);

			customer.Activate();

			_customerRepository.Update(customer);
		}
	}
}
