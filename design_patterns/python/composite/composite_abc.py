import abc


class Component(metaclass=abc.ABCMeta):

    def __init__(self, name):
        self._name = name

    def get_name(self):
        return self._name

    @abc.abstractmethod
    def add_component(self, component):
        pass

    @abc.abstractmethod
    def remove_component(self, component):
        pass

    @abc.abstractmethod
    def get_child(self, index):
        pass

    @abc.abstractmethod
    def display(self, depth, indent):
        pass


class Composite(Component):

    def __init__(self, name):
        super().__init__(name)
        self._children = list()

    def add_component(self, component):
        self._children.append(component)

    def remove_component(self, component):
        self._children.remove(component)

    def get_child(self, index):
        return self._children[index]

    def display(self, depth=0, indent=4):
        print("{}# {}".format(" "*(indent*depth), self.get_name()))
        depth += 1
        for c in self._children:
            c.display(depth)


class Leaf(Component):

    def __init__(self, name):
        super().__init__(name)

    def add_component(self, component):
        pass

    def remove_component(self, component):
        pass

    def get_child(self, index):
        pass

    def display(self, depth=0, indent=4):
        print("{}- {}".format(" "*(indent*depth), self.get_name()))


if __name__ == '__main__':
    root = Composite("Company")

    ceo = Leaf("CEO")
    root.add_component(ceo)
    team1 = Composite("Team 1")
    root.add_component(team1)
    team2 = Composite("Team 2")
    root.add_component(team2)

    lead1 = Leaf("Leader 1")
    team1.add_component(lead1)
    dev1 = Leaf("Developer 1")
    team1.add_component(dev1)
    dev2 = Leaf("Developer 2")
    team1.add_component(dev2)

    lead2 = Leaf("Leader 2")
    team2.add_component(lead2)
    steam1 = Composite("Subteam 1")
    team2.add_component(steam1)
    steam2 = Composite("Subteam 2")
    team2.add_component(steam2)

    root.display()