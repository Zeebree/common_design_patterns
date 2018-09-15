using System.Collections.Generic;
using Observer.Domain;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMonitor stockMonitor = new StockMonitor();
            Stock stock = new Stock("BMW", 11.00m);
            //stockMonitor.SetData(stock);

            BMWObserver bmw = new BMWObserver("BMW", stockMonitor);
            VWObserver vw = new VWObserver("VW", stockMonitor);
            //AudiObserver audi = new AudiObserver(stockMonitor);

            // Stock data examples
            List<Stock> stocks = new List<Stock> {new Stock("BMW", 12.00m), new Stock("VW", 8.00m),
                                                  new Stock("BMW", 12.50m), new Stock("Audi", 10.00m),
                                                  new Stock("VW", 7.50m), new Stock("BMW", 13.50m),
                                                  new Stock("BMW", 14.50m), new Stock("Audi", 10.50m),
                                                  new Stock("Audi", 11.00m), new Stock("VW", 7.00m),};

            foreach (var s in stocks)
            {
                stockMonitor.SetData(s);
            }
        }
    }
}
