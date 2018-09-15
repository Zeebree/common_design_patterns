import abc


class Car(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def turn_on(self):
        pass

    @abc.abstractmethod
    def turn_off(self):
        pass

    @property
    @abc.abstractproperty
    def produced(self):
        pass


class Audi(Car):

    def __init__(self):
        self._produced = None

    def turn_on(self):
        print('Audi is On.')

    def turn_off(self):
        print('Audi is Off.')

    @property
    def produced(self):
        return self._produced

    @produced.setter
    def produced(self, value):
        self._produced = value


class BMW(Car):

    def __init__(self, produced):
        self._produced = produced

    def turn_on(self):
        print('BMW is On.')

    def turn_off(self):
        print('BMW is Off.')

    @property
    def produced(self):
        return self._produced

    @produced.setter
    def produced(self, value):
        self._produced = value


class VW(Car):

    def __init__(self):
        self._produced = None

    def turn_on(self):
        print('VW is On.')

    def turn_off(self):
        print('VW is Off.')

    @property
    def produced(self):
        return self._produced

    @produced.setter
    def produced(self, value):
        self._produced = value


class NullCar(Car):

    def __init__(self):
        self._produced = None

    def turn_on(self):
        raise NotImplementedError

    def turn_off(self):
        raise NotImplementedError

    @property
    def produced(self):
        raise NotImplementedError

    @produced.setter
    def produced(self, value):
        raise NotImplementedError


class CarFactory(metaclass=abc.ABCMeta):

    def __init__(self):
        self._car = None

    @abc.abstractmethod
    def create(self):
        pass

    def test_by_driving(self):
        self._car.turn_on()
        print('Drive a car on test track.')
        self._car.turn_off()

        # Car always pass tests
        print('Car pass tests.')
        return True

    @property
    def order(self):
        self._car = self.create()
        if self.test_by_driving():
            print('Ordered car is delivered.')
            return self._car
        else:
            print('Sorry, but your car is currently unavaiable.')
            return NullCar()


class AudiFactory(CarFactory):

    def create(self):
        car = Audi()
        # Set year of production
        car.produced = 2017
        return car


class BMWFactory(CarFactory):

    def create(self):
        # Set all what you need directly thought constructor
        car = BMW(2017)
        return car


class VWFactory(CarFactory):

    def create(self):
        car = VW()
        # Set year of production
        car.produced = 2017
        return car

        
if __name__ == '__main__':
    bmw_car_factory = BMWFactory()
    bmw = bmw_car_factory.order
    # Go and have some fun with your BMW
    bmw.turn_on()
    bmw.turn_off()

    audi_car_factory = AudiFactory()
    audi = audi_car_factory.order
    # Go and have some fun with your BMW
    audi.turn_on()
    audi.turn_off()        