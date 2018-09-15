using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Aircondition
{
	class AirconditionFactory : AbstractAirconditionCreator
	{
		public override IAircondition CreateAircondition(string type)
		{
			switch (type)
			{
				case "manual":
					return new ManualAircondition();
				case "automatic":
					return new AutomaticAircondition();
				default:
					return new NullAircondition();
			}
		}
	}
}
