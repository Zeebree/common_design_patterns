using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Domain;

namespace Iterator
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<string> cars = new List<string>() { "BMW", "Audi", "VW", "Volvo" };
    //        IAggregate garage = new Garage(cars);
    //        IAggregate hangar = new Hangar();

    //        PrintAggregateItems(garage.CreateIterator());
    //        PrintAggregateItems(hangar.CreateIterator());
    //    }

    //    private static void PrintAggregateItems(IIterator iterator)
    //    {
    //        while (iterator.HasNext())
    //        {
    //            Console.WriteLine(iterator.Next());
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>() { "BMW", "Audi", "VW", "Volvo" };
            Garage garage = new Garage(cars);
            // Or better, instantiate through interface 
            IEnumerable<string> hangar = new Hangar();

            PrintAggregateItems(garage);
            PrintAggregateItems(hangar);

            string justString = "Hello, world!";
            // Client methods can be generic, and only care about interfaces
            // string implements IEnumerable<char>
            PrintAggregateItems(justString);
        }

        private static void PrintAggregateItems<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
