class Garage:

    def __init__(self, cars=None):
        self._cars = cars or []

    def add_car(self, car):
        self._cars.append(car)

    def __iter__(self):
        return GarageIterator(self._cars)


class GarageIterator:

    def __init__(self, cars):
        self._cars = cars
        self._position = 0

    def __iter__(self):
        return self

    def __next__(self):
        if self._cars is None or self._position >= len(self._cars):
            raise StopIteration
        value = self._cars[self._position]
        self._position += 1
        return value


class Hangar:

    def __init__(self):
        self._airplane = tuple(['Antonov', 'Boing', 'Airbus'])

    def __iter__(self):
        return GarageIterator(self._airplane)


class HangarIterator:

    def __init__(self, airplane):
        self._airplane = airplane
        self._position = 0

    def __iter__(self):
        return self

    def __next__(self):
        if self._airplane is None or self._position >= len(self._airplane):
            raise StopIteration
        value = self._airplane[self._position]
        self._position += 1
        return value


if __name__ == '__main__':
    cars = ['BMW', 'Audi', 'VW', 'Volvo']
    garage = Garage(cars)

    hangar = Hangar()

    for item in garage:
        print(item)

    for item in hangar:
        print(item)