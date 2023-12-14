using System.ComponentModel.DataAnnotations;

namespace Aurora.Domain.Entities
{
	public class OrderProduct
	{

		[Key]
        public int Id { get; }
        public int Amount { get; private set; }
        public double Discount { get; private set; }
        public int OrderId { get; private set; }
        public Order Order { get; private set; }
        public Product Product { get; private set; }

		public OrderProduct() { }

		public OrderProduct(Order order, Product product, int amount, double discount)
		{
			Order = order;
			Product = product;
			Amount = amount;
			Discount = discount;
		}

		internal double GetPrice()
			=> (Product.Price - GetDiscountPerProduct()) * Amount;

		private double GetDiscountPerProduct()
			=> Product.Price * Discount;

		internal void SetOrderId(int value)
			=> OrderId = value;
	}
}