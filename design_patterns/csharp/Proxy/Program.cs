using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Domain;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("UltraHD_pic.jpg");
            // Use factory instead of direct instantiations. Client typicaly don't 
            // knows or cares that it's using proxy instead of the concrete subject

            // Image will be loaded to memory and shown .
            image.Display();

            // Image is already loaded! Show image directly from memory.
            image.Display();
        }
    }
}
