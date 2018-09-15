using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Domain
{
    class Adapter : ITarget
    {
        Adaptee _adaptee;
        public Adapter()
        {
            this._adaptee = new Adaptee();
        }


        public void Request()
        {
            this._adaptee.SpecificRequest();
        }
    }
}
