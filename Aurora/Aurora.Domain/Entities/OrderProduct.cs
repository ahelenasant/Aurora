using System.ComponentModel.DataAnnotations;

namespace Aurora.Domain.Entities
{
	public class OrderProduct
	{

		[Key]
        public int Id { get; }
        public int Quantity { get; private set; }
        public double Discount { get; private set; }
        public int OrderId { get; private set; }
        public Order Order { get; private set; }
        public Product Product { get; private set; }

		public OrderProduct() { }

		public OrderProduct(Order order, Product product, int quantity, double discount)
		{
			Order = order;
			Product = product;
			Quantity = quantity;
			Discount = discount;
		}

		internal double GetPrice()
			=> (Product.Price - GetDiscountPerProduct()) * Quantity;

		private double GetDiscountPerProduct()
			=> Product.Price * Discount;

		internal void SetOrderId(int value)
			=> OrderId = value;
	}
}