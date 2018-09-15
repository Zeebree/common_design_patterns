using System;
using FactoryMethod.Domain.Cars;

namespace FactoryMethod.Domain.Creators
{
	abstract class CarFactory
	{
        private ICar _car;

        abstract public ICar Create();

        public bool TestByDriving()
        {
            _car.TurnOn();
            Console.WriteLine("Drive a car on test track.");
            _car.TurnOff();

            // Car always pass tests
            Console.WriteLine("Car pass tests.");
            return true;    
        }

        public ICar Order
        {
            get
            {
                _car = Create();
                if (TestByDriving())
                {
                    Console.WriteLine("Ordered car is delivered.");
                    return _car;
                }
                else
                {
                    Console.WriteLine("Sorry, but your car is currently unavaiable.");
                    return new NullCar();
                }
            }
        }
    }
}
