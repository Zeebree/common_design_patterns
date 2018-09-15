class ConcreteImage:

    def __init__(self, name):
        self._name = name
        self.load_high_resolution_image(self._name)

    # Load image to memory. This is costly operation.
    def load_high_resolution_image(self, name):
        print("Loading image {}.".format(name))

    def display(self):
        print("Render Image {}".format(self._name))


class ProxyImage:

    def __init__(self, name):
        self._name = name
        self._image = None

    def display(self):
        if not self._image:
            self._image = ConcreteImage(self._name)
        self._image.display()


if __name__ == '__main__':
    image = ProxyImage("UltraHD_pic.jpg")

    # Image will be loaded to memory and shown .
    image.display()

    # Image is already loaded! Show image directly from memory.
    image.display()