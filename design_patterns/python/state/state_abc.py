import abc


class State(metaclass=abc.ABCMeta):

    @abc.abstractmethod
    def insert_coin(self):
        pass

    @abc.abstractmethod
    def eject_coin(self):
        pass

    @abc.abstractmethod
    def turn_crank(self):
        pass

    @abc.abstractmethod
    def dispense(self):
        pass


class SoldState(State):

    def __init__(self, machine):
        self._machine = machine

    def insert_coin(self):
        print('Please wait, we are already giving you a soda.')

    def eject_coin(self):
        print('Sorry, you already turned the crank')

    def turn_crank(self):
        print('Turning twice does not get you another soda!')

    def dispense(self):
        self._machine.release_soda()
        if self._machine.count > 0:
            self._machine.set_state(self._machine.NO_COIN)
        else:
            print('Oops, out of sodas!')
            self._machine.set_state(self._machine.SOLD_OUT)


class SoldOutState(State):

    def __init__(self, machine):
        self._machine = machine

    def insert_coin(self):
        print('Oops, out of sodas. Eject your coin.')

    def eject_coin(self):
        print('Coin returned')

    def turn_crank(self):
        print('Oops, out of sodas.')

    def dispense(self):
        print('Oops, out of sodas.')


class NoCoinState(State):

    def __init__(self, machine):
        self._machine = machine

    def insert_coin(self):
        print('You inserted a coin')
        self._machine.set_state(self._machine.HAS_COIN)

    def eject_coin(self):
        print('You have not inserted a coin')

    def turn_crank(self):
        print('You turned, but there is no coin')

    def dispense(self):
        print('You need to pay first')


class HasCoinState(State):

    def __init__(self, machine):
        self._machine = machine

    def insert_coin(self):
        print('You cannot insert another coin')

    def eject_coin(self):
        print('Coin returned')
        self._machine.set_state(self._machine.NO_COIN)

    def turn_crank(self):
        self._machine.set_state(self._machine.SOLD)

    def dispense(self):
        print('No soda to dispensed')


class SodaVendingMachine:

    def __init__(self, count):
        self.SOLD_OUT = SoldOutState(self)
        self.NO_COIN = NoCoinState(self)
        self.HAS_COIN = HasCoinState(self)
        self.SOLD = SoldState(self)

        self.state = self.SOLD_OUT
        self.count = count
        if self.count > 0:
            self.state = self.NO_COIN

    def insert_coin(self):
        self.state.insert_coin()

    def eject_coin(self):
        self.state.eject_coin()

    def turn_crank(self):
        self.state.turn_crank()
        # Note that we don't need an action for dispense(), it's an internal action, user cannot
        # ask machine to dispense directly. Do not directly call self.state.dispense()
        self.dispense()

    def dispense(self):
        self.state.dispense()

    def set_state(self, state):
        self.state = state

    def release_soda(self):
        print('A soda is released.')
        if self.count != 0:
            self.count -= 1
        print('Left soda in machine: {}\n'.format(self.count))


if __name__ == '__main__':
    svm = SodaVendingMachine(10)
    svm.insert_coin()
    svm.turn_crank()

    svm.turn_crank()
    svm.eject_coin()
    svm.insert_coin()
    svm.eject_coin()