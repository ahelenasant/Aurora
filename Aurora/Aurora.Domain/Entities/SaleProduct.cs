using System.ComponentModel.DataAnnotations;

namespace Aurora.Domain.Entities
{
	public class SaleProduct
	{

		[Key]
        public int Id { get; }
        public Sale Sale { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double Discount { get; private set; }

		public SaleProduct() { }

		public SaleProduct(Sale sale, Product product, int quantity, double discount)
		{
			Sale = sale;
			Product = product;
			Quantity = quantity;
			Discount = discount;
		}
	}
}