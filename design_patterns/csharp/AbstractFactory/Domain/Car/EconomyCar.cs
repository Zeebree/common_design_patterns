using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Domain.Equipment;
using AbstractFactory.Domain.Equipment.Aircondition;
using AbstractFactory.Domain.Equipment.Multimedia;


namespace AbstractFactory.Domain.Car
{
	class EconomyCar : ICar
	{
		string carName = "Economy";
		IAircondition aircondition;
		IMultimedia multimedia;
		

		public string Name
		{
			get
			{
				return carName;
			}
		}

		public EconomyCar(IEquipmentAbstractFactory equipmentFactory)
		{
			aircondition = equipmentFactory.CreateAircondition();
			multimedia = equipmentFactory.CreateMultimedia();
		}

		public void Analitycs()
		{
			aircondition.On();
			aircondition.Off();
			multimedia.On();
			multimedia.Off();
		}

		public void TurnOff()
		{
			Console.WriteLine("{0} car is turned off.", Name);
		}

		public void TurnOn()
		{
			Console.WriteLine("{0} car is turned on.", Name);
		}
	}
}
