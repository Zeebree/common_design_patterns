using FactoryMethod.Domain.Cars;

namespace FactoryMethod.Domain.Creators
{
	class VWFactory : CarFactory
	{
		override public ICar Create()
		{
			var car = new VW();
            // Set year of production
            car.Produced = 2017;
			return car;
		}
	}
}
