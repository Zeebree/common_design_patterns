using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Domain
{
    //class Garage : IAggregate
    //{
    //    private List<string> _cars;

    //    public Garage(List<string> cars)
    //    {
    //        this._cars = cars;
    //    }

    //    public void AddCar(string car)
    //    {
    //        this._cars.Add(car);
    //    }

    //    public IIterator CreateIterator()
    //    {
    //        return new GarageIterator(this._cars);
    //    }
    //}

    class Garage : IEnumerable<string>
    {
        private List<string> _cars;

        public Garage(List<string> cars)
        {
            this._cars = cars;
        }

        public void AddCar(string car)
        {
            this._cars.Add(car);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<string>)_cars).GetEnumerator();
            //return _cars.GetEnumerator();
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return ((IEnumerable<string>)_cars).GetEnumerator();
        }
    }
}
