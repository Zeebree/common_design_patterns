using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Multimedia
{
	class StandardMultimedia : IMultimedia
	{
		public void Off()
		{
			Console.WriteLine("Standard multimedia is Off.");
		}

		public void On()
		{
			Console.WriteLine("Standard multimedia is On.");
		}
	}
}
