using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Domain
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            throw new NotSupportedException();
        }

        public override void Remove(Component c)
        {
            throw new NotSupportedException();
        }

        public override Component GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public override void Display(int depth, int indent)
        {
            var ind = String.Concat(Enumerable.Repeat(" ", indent * depth));
            Console.WriteLine("{0}- {1}", ind, Name);
        }
    }
}
