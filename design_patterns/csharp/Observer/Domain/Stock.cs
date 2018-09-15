namespace Observer.Domain
{
	class Stock
	{
		string name;
		decimal price;

		public string Name
		{
			get { return name;}
		}
		public decimal Price
		{
			get { return price; }
			set { price = value;}
		}

		public Stock(string name, decimal price)
		{
			this.name = name;
			this.price = price;
		}
	}
}
