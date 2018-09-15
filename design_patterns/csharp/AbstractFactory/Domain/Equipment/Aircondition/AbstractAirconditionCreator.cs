using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Aircondition
{
	abstract class AbstractAirconditionCreator
	{
		IAircondition aircondition;
		void Initialize()
		{
			Console.WriteLine("Initialize {0} aircondition.", aircondition.Type);
		}

		public abstract IAircondition CreateAircondition(string type);
	}
}
