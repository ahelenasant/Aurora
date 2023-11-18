namespace Aurora.Domain.Entities
{
	public class Sale : BaseEntity
	{
        public Customer Customer { get; private set; }
        public User User { get; private set; }
        public List<SaleProduct> SaleProduct { get; set; }

		public Sale() { }

		public Sale(Customer customer, User user, List<SaleProduct> saleProduct, DateTime register, bool status) : base(register, status)
		{
			Customer = customer;
			User = user;
			SaleProduct = saleProduct;
		}

		public void AddSaleProduct(SaleProduct saleProduct)
			=> SaleProduct.Add(saleProduct);
	}
}
