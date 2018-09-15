namespace Observer.Domain
{
	abstract class AbstractObserver : IObserver
	{
		StockMonitor stockMonitor;

		string name;
		protected decimal price;

		public AbstractObserver(string name, StockMonitor subject)
		{
			this.name = name;
			stockMonitor = subject;
			stockMonitor.Register(this);
			
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public void Update()
		{
			Stock stock = stockMonitor.GetState;
			if (stock.Name == name)
			{
				price = stock.Price;
				doAction();
			}
		}

		
		public abstract void doAction();
		
	}
}
