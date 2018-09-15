using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    class Engine
    {
        public void Set(int power)
        {
            Console.WriteLine("Engine power: {0}hp", power);
        }
    }
}
