using Aurora.Domain.ValueObjects;

namespace Aurora.Domain.Entities
{
	public class CustomerAddress : BaseEntity
	{
        public string Address { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public ZipCode ZipCode { get; private set; }
        public int CityId { get; private set; }
        public int StateId { get; private set; }
        public int CustomerId { get; set; }

        public CustomerAddress() { }

		public CustomerAddress(string address, int number, string complement, string zipCode, int cityId, int stateId, DateTime register, bool status) : base(register, status)
		{
			Address = address;
			Number = number;
			Complement = complement;
			ZipCode = new ZipCode(zipCode);
			CityId = cityId;
			StateId = stateId;
		}
	}
}
