using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Domain
{
	public abstract class IceCreamComponent
	{
		private string component;

		public string Component
		{
			get { return component; }
			set { component = value; }
		}

		public abstract string getDescription();

		public abstract double CalculateCost();
	}
}
