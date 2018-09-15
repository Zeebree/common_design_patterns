using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	public class Vanilla : IceCreamComponent
	{
		public Vanilla()
		{
            Component = "Vanilla";
		}

		public override double CalculateCost()
		{
			return 1.00;
		}

		public override string getDescription()
		{
			return Component;
		}
	}
}
