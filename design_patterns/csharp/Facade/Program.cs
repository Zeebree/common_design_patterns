using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Domain;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var economy = new EconomyCarFacade();
            economy.CreateCar();

            var luxury = new LuxuryCarFacade();
            luxury.CreateCar();
        }
    }
}
