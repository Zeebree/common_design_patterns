using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Domain
{
    class HasCoinState : IState
    {
        private SodaVendingMachine _machine;

        public HasCoinState(SodaVendingMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("No soda to dispensed");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Coin returned");
            _machine.State = _machine.NoCoin;
        }

        public void InsertCoin()
        {
            Console.WriteLine("You cannot insert another coin");
        }

        public void TurnCrank()
        {
            _machine.State = _machine.Sold;
        }
    }
}
