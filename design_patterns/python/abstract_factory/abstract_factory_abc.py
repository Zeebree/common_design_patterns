import abc


class AbstractFactory(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def create_product_a(self):
        pass

    @abc.abstractmethod
    def create_product_b(self):
        pass


class ConcreteFactory1(AbstractFactory):

    def create_product_a(self):
        return ProductA1()

    def create_product_b(self):
        return ProductB1()


class ConcreteFactory2(AbstractFactory):

    def create_product_a(self):
        return ProductA2()

    def create_product_b(self):
        return ProductB2()


class ProductA(metaclass=abc.ABCMeta):
    pass


class ProductA1(ProductA):
    pass


class ProductA2(ProductA):
    pass


class ProductB(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def interact(self, a):
        pass


class ProductB1(ProductB):

    def interact(self, a):
        print(self.__class__.__name__ + " interact with " + a.__class__.__name__)


class ProductB2(ProductB):

    def interact(self, a):
        print(self.__class__.__name__ + " interact with " + a.__class__.__name__)


class Client:

    def __init__(self, factory):
        self.abstract_product_a = factory.create_product_a()
        self.abstract_product_b = factory.create_product_b()

    def do_something(self):
        self.abstract_product_b.interact(self.abstract_product_a)


if __name__ == '__main__':
    factory1 = ConcreteFactory1()
    c1 = Client(factory1)
    c1.do_something()

    factory2 = ConcreteFactory2()
    c2 = Client(factory2)
    c2.do_something()