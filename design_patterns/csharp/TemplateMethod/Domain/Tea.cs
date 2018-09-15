using System;

namespace TemplateMethod.Domain
{
    class Tea : HotBeverage
    {
        internal override void AddMainIngredientInCup()
        {
            Console.WriteLine("Add tea.");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Add lemon.");
        }
    }
}
