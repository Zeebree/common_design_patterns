using System.Collections.Generic;

namespace Observer.Domain
{
	class StockMonitor : ISubject
	{
		Stock last_stock;

		Dictionary<string, IObserver> observers = new Dictionary<string, IObserver>();

		public void Notify()
		{
			foreach (var observer in observers.Values)
			{
				observer.Update();
			}
		}

		public void Register(IObserver observer)
		{
			observers.Add(observer.Name, observer);
		}

		public void Unregister(IObserver observer)
		{
			observers.Remove(observer.Name);
		}

		public void SetData(Stock stock)
		{
			last_stock = stock;
			stockChanges();
		}

		private void stockChanges()
		{
			Notify();
		}

		public Stock GetState
		{
			get 
			{
				return last_stock;
			}
		}
	}
}
