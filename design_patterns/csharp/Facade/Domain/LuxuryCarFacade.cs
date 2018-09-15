using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    public class LuxuryCarFacade
    {
        private readonly Engine engine;
        private readonly Body body;
        private readonly Equipment equipment;

        public LuxuryCarFacade()
        {
            engine = new Engine();
            body = new Body();
            equipment = new Equipment();
        }

        public void CreateCar()
        {
            Console.WriteLine("Creating a Car of Luxury Class");
            engine.Set(350);
            body.Set("Limousine");
            equipment.Set("Full");

            Console.WriteLine("Car of Luxury Class creation is completed.\r\n");
        }
    }
}
