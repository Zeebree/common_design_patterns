using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Domain
{
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {
            this._children.Add(c);
        }

        public override void Remove(Component c)
        {
            this._children.Remove(c);
        }

        public override Component GetChild(int index)
        {
            return this._children[index];
        }

        public override void Display(int depth, int indent)
        {
            var ind = String.Concat(Enumerable.Repeat(" ", indent * depth));
            Console.WriteLine("{0}# {1}", ind, Name);

            depth += 1;
            foreach (var c in _children)
            {
                c.Display(depth, indent);
            }
        }
    }
}
