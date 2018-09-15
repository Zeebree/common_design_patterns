using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Domain
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific method is used.");
        }
    }
}
