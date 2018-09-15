using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain
{
	public class KNNPredictingStrategy : IPredictingStrategy
	{
		public double Calculate()
		{
			// Complex calculation
			return 42.00d;
		}

		public void Work()
		{
			Console.WriteLine("Works!");
		}
	}
}
