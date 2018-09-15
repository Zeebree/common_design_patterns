using System;

namespace FactoryMethod.Domain.Cars
{
	class Audi : ICar
	{
		int produced;
		public void TurnOff()
		{
			Console.WriteLine("Audi is Off.");
		}

		public void TurnOn()
		{
			Console.WriteLine("Audi is On.");
		}

		public int Produced
		{
			get { return produced; }
			set { produced = value; }
		}

	}
}
