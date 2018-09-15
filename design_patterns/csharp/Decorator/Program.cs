using System;
using Decorator.Domain;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamComponent my = new Chocolate();
            my = new CherriesDecorator(my);

            IceCreamComponent your = new Vanilla();
            your = new StrawberriesDecorator(your);

            IceCreamComponent his = new Chocolate();
            his = new StrawberriesDecorator(his);
            his = new CherriesDecorator(his);

            Console.WriteLine("My icecream: {0} and it costs ${1}.", my.getDescription(), my.CalculateCost());
            Console.WriteLine("Your icecream: {0} and it costs ${1}.", your.getDescription(), your.CalculateCost());
            Console.WriteLine("His icecream: {0} and it costs ${1}.", his.getDescription(), his.CalculateCost());
        }
    }
}
