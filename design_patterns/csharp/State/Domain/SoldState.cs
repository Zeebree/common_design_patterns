using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Domain
{
    class SoldState : IState
    {
        private SodaVendingMachine _machine;

        public SoldState(SodaVendingMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            _machine.ReleaseSoda();

            if (_machine.Count > 0)
            {
                _machine.State = _machine.NoCoin;
            }
            else
            {
                Console.WriteLine("Oops, out of sodas!");
                _machine.State = _machine.SoldOut;
            }
                
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Please wait, we are already giving you a soda.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice does not get you another soda!");
        }
    }
}
