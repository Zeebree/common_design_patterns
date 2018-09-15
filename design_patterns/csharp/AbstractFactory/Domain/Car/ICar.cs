using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Car
{
	public interface ICar
	{
		string Name { get; }
		void Analitycs();
		void TurnOn();
		void TurnOff();

	}
}
