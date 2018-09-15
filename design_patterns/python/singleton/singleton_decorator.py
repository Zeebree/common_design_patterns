class SingletonDecorator:

    def __init__(self, klass):
        self._klass = klass
        self._instance = None

    def __call__(self, *args, **kwargs):
        if self._instance is None:
            self._instance = self._klass(*args, **kwargs)
        return self._instance


@SingletonDecorator
class MyClass:

    def __init__(self, a, b=0):
        self._a = a
        self._b = b

    def __str__(self):
        return repr(self) + str((self._a, self._b))


if __name__ == '__main__':
    x = MyClass(1, b=2)
    print(x)        # 1, 2
    y = MyClass(3, b=4)     # No new instance creation, first ever created is returned
    print(y)        # 1, 2
    print(x)        # 1, 2
    print(x is y)   # True, x and y are the same object
