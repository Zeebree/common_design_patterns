using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Domain.Equipment.Aircondition;
using AbstractFactory.Domain.Equipment.Multimedia;

namespace AbstractFactory.Domain.Equipment
{
	class EconomyEquipment : IEquipmentAbstractFactory
	{
		public IAircondition CreateAircondition()
		{
			return new ManualAircondition();
		}

		public IMultimedia CreateMultimedia()
		{
			return new StandardMultimedia();
		}
	}
}
