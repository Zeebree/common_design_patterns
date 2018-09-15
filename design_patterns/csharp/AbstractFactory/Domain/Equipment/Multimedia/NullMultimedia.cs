using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Multimedia
{
	class NullMultimedia : IMultimedia
	{
		public void Off()
		{
			throw new NotImplementedException();
		}

		public void On()
		{
			throw new NotImplementedException();
		}
	}
}
