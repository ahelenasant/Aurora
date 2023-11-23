namespace Aurora.Domain.Entities
{
	public class Product : BaseEntity
	{
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int Stock { get; private set; }

		public Product() { }

		public Product(string description, double price, int stock, DateTime register, bool status) : base(register, status)
		{
			Description = description;
			Price = price;
			Stock = stock;
		}

		public void RemoveStockItems(int value)
		{
			if (VerifyStock(value))
			{
				Stock -= value;
			}
			else
			{
				throw new InvalidOperationException($"Produto {Description} sem estoque!");
			}
		}

		private bool VerifyStock(int value)
			=> Stock > 0 && Stock > value;
    }
}
