using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Multimedia
{
	class TopMultimedia : IMultimedia
	{
		public void Off()
		{
			Console.WriteLine("10 inch screen multimedia is Off.");
		}

		public void On()
		{
			Console.WriteLine("10 inch screen multimedia is On.");
		}
	}
}
