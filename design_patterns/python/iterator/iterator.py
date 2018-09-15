class Garage:

    def __init__(self, cars=None):
        self._cars = cars or []

    def add_car(self, car):
        self._cars.append(car)

    def create_iterator(self):
        return GarageIterator(self._cars)


class GarageIterator:

    def __init__(self, cars):
        self._cars = cars
        self._position = 0

    def has_next(self):
        if self._cars is None or self._position >= len(self._cars):
            return False
        else:
            return True

    def next(self):
        if not self.has_next():
            raise StopIteration
        value = self._cars[self._position]
        self._position += 1
        return value


class Hangar:

    def __init__(self):
        self._airplane = tuple(['Antonov', 'Boing', 'Airbus'])

    def create_iterator(self):
        return GarageIterator(self._airplane)


class HangarIterator:

    def __init__(self, airplane):
        self._airplane = airplane
        self._position = 0

    def has_next(self):
        if self._airplane is None or self._position >= len(self._airplane):
            return False
        else:
            return True

    def next(self):
        if not self.has_next():
            raise StopIteration
        value = self._airplane[self._position]
        self._position += 1
        return value


def print_aggregate_items(iterator):
    while iterator.has_next():
        print(iterator.next())


if __name__ == '__main__':
    cars = ['BMW', 'Audi', 'VW', 'Volvo']
    garage = Garage(cars)
    hangar = Hangar()

    print_aggregate_items(garage.create_iterator())
    print_aggregate_items(hangar.create_iterator())