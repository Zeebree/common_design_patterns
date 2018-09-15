class Adapter:

    def __init__(self):
        self._adaptee = Adaptee()

    def request(self):
        self._adaptee.specific_request()


class Adaptee:

    def specific_request(self):
        print("Specific method is used.")


if __name__ == "__main__":
    adapter = Adapter()
    adapter.request()