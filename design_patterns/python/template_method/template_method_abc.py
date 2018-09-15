import abc


class HotBeverage(metaclass=abc.ABCMeta):

    def create(self):
        self.boil_water()
        self.add_main_ingredient_in_cup()
        self.pour_water_in_cup()
        if self.customer_wants_condiments():
            self.add_condiments()
        self.notify()

    def boil_water(self):
        print('Boil water.')

    @abc.abstractmethod
    def add_main_ingredient_in_cup(self):
        pass

    def pour_water_in_cup(self):
        print('Pour hot water into cup')

    def customer_wants_condiments(self):
        return True

    @abc.abstractmethod
    def add_condiments(self):
        pass

    def notify(self):
        print("Hot drink is ready. Bon appetit!\n")


class Tea(HotBeverage):
    def add_main_ingredient_in_cup(self):
        print('Add tea.')

    def add_condiments(self):
        print('Add lemon')


class Coffee(HotBeverage):
    def add_main_ingredient_in_cup(self):
        print('Drip coffee through filter.')

    def add_condiments(self):
        print('Add milk')

    def customer_wants_condiments(self):
        print('Do you want milk?')
        response = input("'y/n:'")
        if response.startswith('y'):
            return True
        return False


if __name__ == '__main__':
    Tea().create()
    Coffee().create()