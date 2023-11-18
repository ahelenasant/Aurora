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

		public void AddStockItems(int value)
			=> Stock += value;

		public void RemoveStockItems(int value)
			=> Stock -= value;

		public void UpdatePrice(double value)
			=> Price = value;
    }
}
