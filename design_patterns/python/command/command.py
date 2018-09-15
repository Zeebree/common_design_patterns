class Pizza:

    def bake(self):
        print("Pizza is baked.")


class Sandwich:

    def make(self):
        print("Sandwich is made.")


class Spaghetti:

    def cook(self):
        print("Spaghetti are cooked.")


class PizzaCommand:

    def __init__(self):
        self._pizza = Pizza()

    def execute(self):
        self._pizza.bake()


class SandwichCommand:

    def __init__(self):
        self._sandwich = Sandwich()

    def execute(self):
        self._sandwich.make()


class SpaghettiCommand:

    def __init__(self):
        self._spaghetti = Spaghetti()

    def execute(self):
        self._spaghetti.cook()


class WaiterInvoker:

    def __init__(self, command):
        self._command = command

    def bring_food(self):
        self._command.execute()


if __name__ == '__main__':
    waiter = WaiterInvoker(PizzaCommand())
    waiter.bring_food()
    waiter = WaiterInvoker(SandwichCommand())
    waiter.bring_food()
    waiter = WaiterInvoker(SpaghettiCommand())
    waiter.bring_food()