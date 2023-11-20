namespace Aurora.Domain.Entities
{
	public class Order : BaseEntity
	{
        public Customer Customer { get; private set; }
        public User User { get; private set; }
        public List<OrderProduct> SaleProduct { get; set; }

		public Order() { }

		public Order(Customer customer, User user, List<OrderProduct> saleProduct, DateTime register, bool status) : base(register, status)
		{
			Customer = customer;
			User = user;
			SaleProduct = saleProduct;
		}

		public void AddOrderProduct(OrderProduct saleProduct)
			=> SaleProduct.Add(saleProduct);
	}
}
