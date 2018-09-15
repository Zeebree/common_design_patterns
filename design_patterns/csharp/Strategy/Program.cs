using System;
using Strategy.Domain;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            // can use interface but in that case only methods declared in interface can be used
            //IPredictingStrategy strategy1 = new KNNPredictingStrategy();	
            //strategy1.Work();
            KNNPredictingStrategy strategy1 = new KNNPredictingStrategy();
            strategy1.Work();   // method not declared in interface
            StockPricePredictor stockPricePredictor1 = new StockPricePredictor(strategy1);    // passing a strategy to context
            double result1 = stockPricePredictor1.CalculatePrediction();
            Console.WriteLine("KNN: " + result1);

            LinearRegressionStrategy strategy2 = new LinearRegressionStrategy();
            StockPricePredictor stockPricePredictor2 = new StockPricePredictor(strategy2);    // passing a strategy to context
            double result2 = stockPricePredictor2.CalculatePrediction();
            Console.WriteLine("Linear regression: " + result2);

            KMeansStrategy strategy3 = new KMeansStrategy();
            StockPricePredictor stockPricePredictor3 = new StockPricePredictor(strategy3);    // passing a strategy to context
            double result3 = stockPricePredictor3.CalculatePrediction();
            Console.WriteLine("K-means: " + result3);
        }
    }
}
