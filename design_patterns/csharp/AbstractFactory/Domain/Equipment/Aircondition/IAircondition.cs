using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Aircondition
{
	interface IAircondition
	{
		string Type { get; }
		void On();
		void Off();
	}
}
