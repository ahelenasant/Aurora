using Aurora.Domain.ValueObjects;

namespace Aurora.Domain.Entities
{
	public class Customer : BaseEntity
	{
        public string Name { get; private set; }
        public DateTime Birthdate { get; private set; }
        public Document Document { get; private set; }
        public List<CustomerAddress> Addresses { get; private set; }

        public Customer() { }

		public Customer(string name, DateTime birthdate, string document, DateTime register, bool status) : base(register, status)
		{
			Name = name;
			Birthdate = birthdate;
			Document = new Document(document);
		}

		public void AddAddress(CustomerAddress address)
		{
			Addresses.Add(address);
		}
	}
}
