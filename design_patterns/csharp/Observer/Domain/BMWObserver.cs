using System;

namespace Observer.Domain
{
	class BMWObserver : AbstractObserver
	{
		public BMWObserver(string name, StockMonitor subject) : base(name, subject)
		{
		}

		public override void doAction()
		{
			if (price >= 13.00m)
			{
				Console.WriteLine("Buy some BMW stocks...");
			}
			if (price > 12.00m & price < 13.00m)
			{
				Console.WriteLine("Do nothing with BMW stocks...");
			}
			if (price <= 12.00m)
			{
				Console.WriteLine("Sell some BMW stocks...");
			}
		}
	}
}
