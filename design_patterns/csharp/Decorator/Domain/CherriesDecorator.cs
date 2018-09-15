using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	class CherriesDecorator : IceCreamDecorator
	{
		public CherriesDecorator(IceCreamComponent iceCream) : base(iceCream)
		{
		}

		public override double CalculateCost()
		{
			return IceCream.CalculateCost() + 0.75; ;
		}

		public override string getDescription()
		{
			return IceCream.getDescription() + ", " + "Cherries";
		}

	}
}
