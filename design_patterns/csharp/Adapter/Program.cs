using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Domain;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Domain.Adapter();
            target.Request();
        }
    }
}
