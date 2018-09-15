using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    class Body
    {
        public void Set(string type)
        {
            Console.WriteLine("Body type: {0}", type);
        }
    }
}
