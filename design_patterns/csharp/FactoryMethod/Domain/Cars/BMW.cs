using System;

namespace FactoryMethod.Domain.Cars
{
	class BMW : ICar
	{
		int produced;

		public BMW(int produced)
		{
			Produced = produced;
		}
		public void TurnOff()
		{
			Console.WriteLine("BMW is Off.");
		}

		public void TurnOn()
		{
			Console.WriteLine("BMW is On.");
		}

		public int Produced
		{
			get { return produced; }
			set { produced = value; }
		}
	}
}
