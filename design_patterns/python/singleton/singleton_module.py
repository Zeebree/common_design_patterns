_registry = dict()


def set(key, value):
    _registry[key] = value


def get(key):
    return _registry[key]