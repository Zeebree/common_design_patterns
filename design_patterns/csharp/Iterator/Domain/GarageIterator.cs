using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Domain
{
    class GarageIterator : IIterator
    {
        private List<string> _cars;
        private int _position = 0;

        public GarageIterator(List<string> cars)
        {
            this._cars = cars;
        }

        public bool HasNext()
        {
            if (this._cars is null | this._position >= this._cars.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string Next()
        {
            if (!HasNext())
            {
                throw new Exception("Stop iteration.");
            }
            var value = this._cars[this._position];
            this._position += 1;
            return value;
        }
    }
}
