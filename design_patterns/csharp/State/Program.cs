using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Domain;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaVendingMachine svm = new SodaVendingMachine(10);
            svm.InsertCoin();
            svm.TurnCrank();

            svm.TurnCrank();
            svm.EjectCoin();
            svm.InsertCoin();
            svm.EjectCoin();
            //svm.ReleaseSoda();
        }
    }
}
