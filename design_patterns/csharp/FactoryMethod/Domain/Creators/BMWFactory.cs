using FactoryMethod.Domain.Cars;

namespace FactoryMethod.Domain.Creators
{
	class BMWFactory : CarFactory
	{
		override public ICar Create()
		{
            // Set all what you need directly thought constructor
            var car = new BMW(2017);
			
			return car;
		}
	}
}
