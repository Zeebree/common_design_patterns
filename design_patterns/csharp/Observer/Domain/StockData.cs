using System.Collections.Generic;

namespace Observer.Domain
{
	class StockData
	{
		//private static string[] companies = new string[] { "BMW", "VW", "BMW", "Audi", "VW", "BMW", "BMW", "Audi", "Audi", "VW" };
		//private static decimal[] prices = new decimal[] { 12.00m, 8.00m, 12.50m, 10.00m, 7.50m, 13.50m, 14.50m, 10.50m, 11.00m, 7.00m };
		//private static IEnumerable<Stock> getNext()
		//{
		//	for (int i = 0; i < companies.Length; i++)
		//	{
		//		Stock s = new Stock();
		//		s.Name = companies[i];
		//		s.Price = prices[i];
		//		yield return s;

		//	}
		//}
		List<Stock> stocks = new List<Stock> {new Stock("BMW", 12.00m), new Stock("VW", 8.00m), new Stock("BMW", 12.50m), new Stock("Audi", 10.00m), new Stock("VW", 7.50m),
											  new Stock("BMW", 13.50m), new Stock("BMW", 14.50m), new Stock("Audi", 10.50m), new Stock("Audi", 11.00m), new Stock("VW", 7.00m),};
	}
}
