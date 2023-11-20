using System.ComponentModel.DataAnnotations;

namespace Aurora.Domain.Entities
{
	public class OrderProduct
	{

		[Key]
        public int Id { get; }
        public Order Sale { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double Discount { get; private set; }

		public OrderProduct() { }

		public OrderProduct(Order sale, Product product, int quantity, double discount)
		{
			Sale = sale;
			Product = product;
			Quantity = quantity;
			Discount = discount;
		}
	}
}