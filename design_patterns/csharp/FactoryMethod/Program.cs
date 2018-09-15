using FactoryMethod.Domain.Cars;
using FactoryMethod.Domain.Creators;


namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //All classes, BMW, VW and Audi, implement the same interface. But they each need their own  
            //specific construction,and we are using factories to centralize the logic of that construction.
            CarFactory bmwCarFactory = new BMWFactory();
            ICar bmw = bmwCarFactory.Order;
            // Go and have some fun with your BMW
            bmw.TurnOn();
            bmw.TurnOff();

            CarFactory audiCarFactory = new AudiFactory();
            ICar audi = audiCarFactory.Order;
            // Go and have some fun with your Audi
            audi.TurnOn();
            audi.TurnOff();
        }
    }
}
