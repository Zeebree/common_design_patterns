using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain.Equipment.Multimedia
{
	class MultimediaFactory : AbstractMultimediaCreator
	{
		public override IMultimedia CreateMultimedia(string type)
		{
			switch (type)
			{
				case "standard":
					return new StandardMultimedia();
				case "top":
					return new TopMultimedia();
				default:
					return new NullMultimedia();
			}
		}
	}
}
