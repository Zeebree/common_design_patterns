using System;

namespace Observer.Domain
{
	class VWObserver : AbstractObserver
	{
		public VWObserver(string name, StockMonitor subject) : base(name, subject)
		{
		}

		public override void doAction()
		{
			if (price >= 12.00m)
			{
				Console.WriteLine("Buy some VW stocks...");
			}
			if (price > 10.00m & price < 12.00m)
			{
				Console.WriteLine("Do nothing with VW stocks...");
			}
			if (price <= 10.00m)
			{
				Console.WriteLine("Sell some VW stocks...");
			}
		}
	}
}
