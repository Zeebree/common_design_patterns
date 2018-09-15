using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Domain.Equipment;
using AbstractFactory.Domain.Car;

namespace AbstractFactory
{
	public class CarFactory : AbstractCarFactory
	{

		protected override ICar CreateCar(string carName)
		{
			IEquipmentAbstractFactory equipmentFactory;
			switch (carName)
			{
				case "economy":
					equipmentFactory = new EconomyEquipment();
					return new EconomyCar(equipmentFactory);
				case "premium":
					equipmentFactory = new TopEquipment();
					return new PremiumCar(equipmentFactory);
				default:
					return new NullCar();
			}
		}
	}
}
