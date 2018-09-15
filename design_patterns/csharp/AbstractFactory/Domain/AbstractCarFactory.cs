using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Domain.Car;

namespace AbstractFactory
{
	public abstract class AbstractCarFactory
	{
		ICar car;

		internal ICar Car
		{
			get
			{
				return car;
			}

			set
			{
				car = value;
			}
		}

		bool TestCar()
		{
			Console.WriteLine("Car under test...");
			Car.TurnOn();
			Car.Analitycs();
			Car.TurnOff();
			Console.WriteLine("Car is tested.");

			// in this example tested car allways pass tests 
			return true;
		}

		public ICar GetCar(string carName)
		{
			Car = CreateCar(carName);
			if (TestCar())
			{
				return Car;
			}
			else
			{
				throw new Exception("Car not pass tests!");
			}

		}

		protected abstract ICar CreateCar(string carName);

	}
}
