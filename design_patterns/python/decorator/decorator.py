class Chocolate:

    def __init__(self):
        self.component = 'Chocolate'

    def get_description(self):
        return self.component

    def calculate_cost(self):
        return 1.20


class Vanilla:

    def __init__(self):
        self.component = 'Vanilla'

    def get_description(self):
        return self.component

    def calculate_cost(self):
        return 1.00


class IceCreamDecorator:

    def __init__(self, component):
        self._component = component


class CherriesDecorator(IceCreamDecorator):

    def get_description(self):
        return self._component.get_description() + ', ' + 'Cherries'

    def calculate_cost(self):
        return self._component.calculate_cost() + 0.75


class StrawberriesDecorator(IceCreamDecorator):

    def get_description(self):
        return self._component.get_description() + ', ' + 'Strawberies'

    def calculate_cost(self):
        return self._component.calculate_cost() + 0.90


if __name__ == '__main__':
    my = Chocolate()
    my = CherriesDecorator(my)

    your = Vanilla()
    your = StrawberriesDecorator(your)

    his = Chocolate()
    his = CherriesDecorator(StrawberriesDecorator(his))

    print("My icecream: {0} and it costs ${1}.".format(my.get_description(), my.calculate_cost()))
    print("Your icecream: {0} and it costs ${1}.".format(your.get_description(), your.calculate_cost()))
    print("His icecream: {0} and it costs ${1}.".format(his.get_description(), his.calculate_cost()))