using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    public class EconomyCarFacade
    {
        private readonly Engine engine;
        private readonly Body body;
        private readonly Equipment equipment;

        public EconomyCarFacade()
        {
            engine = new Engine();
            body = new Body();
            equipment = new Equipment();
        }

        public void CreateCar()
        {
            Console.WriteLine("Creating a Car of Economy Class");
            engine.Set(100);
            body.Set("Hatchback");
            equipment.Set("Basic");

            Console.WriteLine("Car of Economy Class creation is completed.\r\n");
        }
    }
}
