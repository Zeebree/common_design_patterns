class SingletonNew:

    __instance = None

    def __new__(cls, val):
        if SingletonNew.__instance is None:
            SingletonNew.__instance = object.__new__(cls)
        SingletonNew.__instance.val = val
        return SingletonNew.__instance


if __name__ == '__main__':
    x = SingletonNew('sausage')
    print(x)
    print(x.val)
    y = SingletonNew('eggs')
    print(y)
    print(y.val)
    z = SingletonNew('spam')
    print(z)
    print(z.val)
    print(x)
    print(x.val)
    print(y)
    print(y.val)
