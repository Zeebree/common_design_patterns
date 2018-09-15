import abc


class Subject(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def register(self, observer):
        pass

    @abc.abstractmethod
    def unregister(self, observer):
        pass

    @abc.abstractmethod
    def notify(self):
        pass


class Observer(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def update(self):
        pass


class BaseObserver(Observer, metaclass=abc.ABCMeta):

    def __init__(self, name, subject):
        self._subject = subject
        self._name = name
        self._subject.register(self)
        self._price = None

    @property
    def name(self):
        return self._name

    def update(self):
        stock = self._subject.get_state()
        if stock.name == self._name:
            self._price = stock.price
            self.do_action()

    @abc.abstractmethod
    def do_action(self):
        pass


class StockMonitor(Subject):

    def __init__(self):
        self._last_stock = None
        self._observers = dict()

    def register(self, observer):
        self._observers[observer.name] = observer

    def unregister(self, observer):
        del self._observers[observer.name]

    def notify(self):
        for o in self._observers.values():
            o.update()

    def get_state(self):
        return self._last_stock

    def _stock_changes(self):
        self.notify()

    def set_data(self, stock):
        self._last_stock = stock
        self._stock_changes()


class BMWObserver(BaseObserver):

    def __init__(self, name, subject):
        super().__init__(name, subject)

    def do_action(self):
        if self._price >= 13:
            print("Buy some BMW stocks...")
        if 12 < self._price < 13:
            print("Do nothing with BMW stocks...")
        if self._price <= 12:
            print("Sell some BMW stocks...")


class VWObserver(BaseObserver):

    def __init__(self, name, subject):
        super().__init__(name, subject)

    def do_action(self):
        if self._price >= 12:
            print("Buy some VW stocks...")
        if 10 < self._price < 12:
            print("Do nothing with VW stocks...")
        if self._price <= 10:
            print("Sell some VW stocks...")


class Stock:

    def __init__(self, name, price):
        self._price = price
        self._name = name

    @property
    def name(self):
        return self._name

    @name.setter
    def name(self, value):
        self._name = value

    @property
    def price(self):
        return self._price

    @price.setter
    def price(self, value):
        self._price = value


if __name__ == '__main__':
    stock_monitor = StockMonitor()
    stock = Stock("BMW", 11)

    bmw = BMWObserver("BMW", stock_monitor)
    vw = VWObserver("VW", stock_monitor)

    stocks = [Stock("BMW", 12.00), Stock("VW", 8.00),
              Stock("BMW", 12.50), Stock("Audi", 10.00),
              Stock("VW", 7.50), Stock("BMW", 13.50),
              Stock("BMW", 14.50), Stock("Audi", 10.50),
              Stock("Audi", 11.00), Stock("VW", 7.00)]

    for s in stocks:
        stock_monitor.set_data(s)