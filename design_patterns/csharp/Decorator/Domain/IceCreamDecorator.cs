using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	public abstract class IceCreamDecorator : IceCreamComponent
	{
		IceCreamComponent _iceCream;
		
		public IceCreamDecorator(IceCreamComponent iceCream)
		{
			_iceCream = iceCream;
		}

		public IceCreamComponent IceCream
		{
			get { return _iceCream; }
		}
	}
}
