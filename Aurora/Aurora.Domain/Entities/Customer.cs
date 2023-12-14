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
			=> Addresses.Add(address);

		public void FillInAddress(int id)
			=> Addresses.ForEach(a => a.CustomerId = this.Id);

		internal void VerifyStatus()
		{
			throw new NotImplementedException();
		}
	}
}
