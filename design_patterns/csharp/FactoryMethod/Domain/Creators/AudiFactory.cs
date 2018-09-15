using FactoryMethod.Domain.Cars;

namespace FactoryMethod.Domain.Creators
{
	class AudiFactory : CarFactory
	{
		override public ICar Create()
		{
			var car = new Audi();
            // Set year of production
            car.Produced = 2017;
			return car;
		}
	}
}
