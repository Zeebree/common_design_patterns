class KMeans:

    def calculate(self):
        # Complex calculate
        return 33.22


class KNN:

    def calculate(self):
        # Complex calculate
        return 42.00

    def work(self):
        print("Works!")


class LinearRegression:

    def calculate(self):
        # Complex calculate
        return 37.11


class StockPricePredictor:

    def __init__(self, predicting_strategy):
        self._predicting_strategy = predicting_strategy

    def calculate_prediction(self):
        return self._predicting_strategy.calculate()


if __name__ == '__main__':
    strategy1 = KNN()
    strategy1.work()
    stock_price_predictor = StockPricePredictor(strategy1)
    result1 = stock_price_predictor.calculate_prediction()
    print("KNN: {}".format(result1))

    strategy2 = LinearRegression()
    stock_price_predictor = StockPricePredictor(strategy2)
    result1 = stock_price_predictor.calculate_prediction()
    print("Linear regression: {}".format(result1))

    strategy3 = KMeans()
    stock_price_predictor = StockPricePredictor(strategy3)
    result1 = stock_price_predictor.calculate_prediction()
    print("K-means: {}".format(result1))