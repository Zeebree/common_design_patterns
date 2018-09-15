using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	class StrawberriesDecorator : IceCreamDecorator
	{
		public StrawberriesDecorator(IceCreamComponent iceCream) : base(iceCream)
		{
		}

		public override double CalculateCost()
		{
			return IceCream.CalculateCost() + 0.90;
		}

		public override string getDescription()
		{
			return IceCream.getDescription() + ", " + "Strawberies";
		}

	}
}
