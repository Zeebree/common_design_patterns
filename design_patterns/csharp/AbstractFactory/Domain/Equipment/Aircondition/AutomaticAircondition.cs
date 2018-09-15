using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Aircondition
{
	class AutomaticAircondition : IAircondition
	{
		string type;
		public string Type
		{
			get
			{
				return type;
			}
			private set
			{
				type = value;
			}
		}

		public AutomaticAircondition()
		{
			Type = "Automatic";
		}

		public void Off()
		{
			Console.WriteLine("{0} aircondition is Off.", Type);
		}

		public void On()
		{
			Console.WriteLine("{0} aircondition is On.", Type);
		}
	}
}
