using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Car
{
	class NullCar : ICar
	{
		public string Name
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public void Analitycs()
		{
			throw new NotImplementedException();
		}

		public void TurnOff()
		{
			throw new NotImplementedException();
		}

		public void TurnOn()
		{
			throw new NotImplementedException();
		}
	}
}
