using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Domain
{
    class HangarIterator : IIterator
    {
        private string[] _airplanes;
        private int _position = 0;

        public HangarIterator(string[] airplanes)
        {
            this._airplanes = airplanes;
        }
        public bool HasNext()
        {
            if (this._airplanes is null | this._position >= this._airplanes.Length)
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
                throw new Exception("Stop iteration");
            }

            var value = this._airplanes[this._position];
            this._position += 1;
            return value;
        }
    }
}
