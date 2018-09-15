using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    class Equipment
    {
        public void Set(string type)
        {
            Console.WriteLine("Equipment: {0}", type);
        }
    }
}
