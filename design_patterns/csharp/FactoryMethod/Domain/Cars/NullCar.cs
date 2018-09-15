using System;

namespace FactoryMethod.Domain.Cars
{
	class NullCar : ICar
	{
		public int Produced
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public void TurnOff()
		{
			throw new NotImplementedException();
		}

		public void TurnOn()
		{
			throw new NotImplementedException();
		}
	}
}
