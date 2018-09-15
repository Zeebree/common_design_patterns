class SingletonMeta(type):

    def __init__(cls, name, bases, dict):
        super(SingletonMeta, cls).__init__(name, bases, dict)
        cls._instance = None

    def __call__(cls, *args, **kwargs):
        if cls._instance is None:
            cls._instance = super(SingletonMeta, cls).__call__(*args, **kwargs)
        return cls._instance


class MyClassM(metaclass=SingletonMeta):

    def __init__(self, a, b=0):
        self._a = a
        self._b = b

    def __str__(self):
        return repr(self) + str((self._a, self._b))


if __name__ == '__main__':
    x = MyClassM(1, b=2)
    print(x)            # 1, 2
    y = MyClassM(3, b=4)    # No new instance creation, first ever created is returned
    print(y)            # 1, 2
    print(x)            # 1, 2
    print(x is y)       # True, x and y are the same object
