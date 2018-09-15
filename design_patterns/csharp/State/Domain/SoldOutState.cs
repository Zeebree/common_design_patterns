using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Domain
{
    class SoldOutState : IState
    {
        private SodaVendingMachine _machine;

        public SoldOutState(SodaVendingMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Oops, out of sodas.");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Coin returned");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Oops, out of sodas. Eject your coin.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Oops, out of sodas.");
        }
    }
}
