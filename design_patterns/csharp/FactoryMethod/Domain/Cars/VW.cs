using System;

namespace FactoryMethod.Domain.Cars
{
	class VW : ICar
	{
		int produced;
		public void TurnOff()
		{
			Console.WriteLine("VW is Off.");
		}

		public void TurnOn()
		{
			Console.WriteLine("VW is On.");
		}

		public int Produced
		{
			get { return produced; }
			set { produced = value; }
		}
	}
}
