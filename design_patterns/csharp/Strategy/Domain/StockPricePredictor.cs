namespace Strategy.Domain
{
	class StockPricePredictor
	{
		readonly IPredictingStrategy predictingStrategy;

		public StockPricePredictor(IPredictingStrategy predictingStrategy)
		{
			this.predictingStrategy = predictingStrategy;
		}

		public double CalculatePrediction()
		{
			return predictingStrategy.Calculate();
		}
	}
}
