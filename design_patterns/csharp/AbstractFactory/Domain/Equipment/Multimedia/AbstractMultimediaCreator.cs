using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Multimedia
{
	abstract class AbstractMultimediaCreator
	{
		void InstallSoftware()
		{
			Console.WriteLine("Install software on multimedia device.");
		}

		public abstract IMultimedia CreateMultimedia(string type);
	}
}
