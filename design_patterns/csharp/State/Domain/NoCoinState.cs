using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Domain
{
    class NoCoinState : IState
    {
        private SodaVendingMachine _machine;

        public NoCoinState(SodaVendingMachine machine)
        {
            this._machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectCoin()
        {
            Console.WriteLine("You have not inserted a coin");
        }

        public void InsertCoin()
        {
            Console.WriteLine("You inserted a coin");
            _machine.State = _machine.HasCoin;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no coin");
        }
    }
}
