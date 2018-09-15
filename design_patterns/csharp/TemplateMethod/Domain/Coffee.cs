using System;

namespace TemplateMethod.Domain
{
    class Coffee : HotBeverage
    {
        internal override void AddMainIngredientInCup()
        {
            Console.WriteLine("Drip coffee through filter.");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Add milk");
        }

        internal override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want milk?");
            Console.Write("'y/n:'");
            var s = Console.ReadLine();
            if (s == "y")
            {
                return true;
            }
            return false;
        }
    }
}
