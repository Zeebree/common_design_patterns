class Engine:

    def set(self, power):
        print("Engine power: {0}".format(power))


class Body:

    def set(self, type):
        print("Body typo: {0}".format(type))


class Equipment:

    def set(self, type):
        print("Equipment: {0}".format(type))


class EconomyCarFacade:

    def __init__(self):
        self._engine = Engine()
        self._body = Body()
        self._equipment = Equipment()

    def create_car(self):
        print("Creating a Car of Economy Class")
        self._engine.set(100)
        self._body.set("Hatchback")
        self._equipment.set("Basic")
        print("Car of Economy Class creation is completed.\n")


class LuxuryCarFacade:

    def __init__(self):
        self._engine = Engine()
        self._body = Body()
        self._equipment = Equipment()

    def create_car(self):
        print("Creating a Car of Luxury Class")
        self._engine.set(350)
        self._body.set("Limousine")
        self._equipment.set("Full")
        print("Car of Luxury Class creation is completed.\n")


if __name__ == "__main__":
    economy = EconomyCarFacade()
    economy.create_car()

    luxury = LuxuryCarFacade()
    luxury.create_car()