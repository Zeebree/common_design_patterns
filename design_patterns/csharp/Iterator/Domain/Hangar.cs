using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Domain
{
    //class Hangar : IAggregate
    //{
    //    private string[] _airplanes;

    //    public Hangar()
    //    {
    //        this._airplanes = new string[] { "Antonov", "Boing", "Airbus" };
    //    }

    //    public IIterator CreateIterator()
    //    {
    //        return new HangarIterator(this._airplanes);
    //    }
    //}


    class Hangar : IEnumerable<string>
    {
        private string[] _airplanes;

        public Hangar()
        {
            this._airplanes = new string[] { "Antonov", "Boing", "Airbus" };
        }

        public IEnumerator<string> GetEnumerator()
        {
            // Arrays (and other C# collections) implement IEnumerable<T>. So we can pass array directly.
            return ((IEnumerable<string>)_airplanes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<string>)_airplanes).GetEnumerator();
        }

    }
}
