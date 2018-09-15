using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Domain.Car;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{

			AbstractCarFactory carFactory = new CarFactory();
			ICar economy = carFactory.GetCar("economy");
			ICar premium = carFactory.GetCar("premium");
		}
	}
}
