using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Domain
{
    class SodaVendingMachine
    {
        private int _count;
        IState _state;

        public int Count { get => _count; set => _count = value; }
        internal IState State { get => _state; set => _state = value; }
        internal IState SoldOut { get => soldOut; set => soldOut = value; }
        internal IState Sold { get => sold; set => sold = value; }
        internal IState NoCoin { get => noCoin; set => noCoin = value; }
        internal IState HasCoin { get => hasCoin; set => hasCoin = value; }

        IState soldOut;
        IState sold;
        IState noCoin;
        IState hasCoin;


        public SodaVendingMachine(int count)
        {
            SoldOut = new SoldOutState(this);
            Sold = new SoldState(this);
            NoCoin = new NoCoinState(this);
            HasCoin = new HasCoinState(this);
            Count = count;

            if (Count > 0)
            {
                State = NoCoin;
            }
            else
            {
                State = SoldOut;
            }

        }

        private void Dispense()
        {
            State.Dispense();
        }

        public void EjectCoin()
        {
            State.EjectCoin();
        }

        public void InsertCoin()
        {
            State.InsertCoin();
        }

        public void TurnCrank()
        {
            State.TurnCrank();

            // Note that we don't need an action for dispense(), it's an internal action, user cannot
            // ask machine to dispense directly. Do not directly call self.state.dispense()
            State.Dispense();
        }

        public void ReleaseSoda()
        {
            Console.WriteLine("A soda is released.");
            if (Count != 0)
            {
                Count -= 1;
            }
            Console.WriteLine("Left soda in machine: {0}.", Count);
        }
    }
}
