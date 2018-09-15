using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	public class Chocolate : IceCreamComponent
	{

		public Chocolate() : base()
		{
			Component = "Chocolate";
		}

		public override double CalculateCost()
		{
			return 1.20;
		}

		public override string getDescription()
		{
			return Component;
		}
	}
}
