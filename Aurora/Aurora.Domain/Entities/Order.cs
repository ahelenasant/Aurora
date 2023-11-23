namespace Aurora.Domain.Entities
{
	public class Order : BaseEntity
	{
        public Customer Customer { get; private set; }
        public User User { get; private set; }
        public double Price { get; private set; }
        public List<OrderProduct> OrderProducts { get; private set; }

        public Order() { }

		public Order(Customer customer, User user, List<OrderProduct> orderProduct, DateTime register, bool status) : base(register, status)
		{
			Customer = customer;
			User = user;
			OrderProducts = orderProduct;
		}

		public void CalculatePrice()
		{
			Price = OrderProducts.Sum(p => p.GetPrice());
		}

		public void UpdateStock()
			=> OrderProducts.ForEach(p => p.Product.RemoveStockItems(p.Quantity));

		public void FillOrderProducts(int id)
			=> OrderProducts.ForEach(p => p.SetOrderId(id));
	}
}
