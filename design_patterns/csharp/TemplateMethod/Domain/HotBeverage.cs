using System;

namespace TemplateMethod.Domain
{
    abstract class HotBeverage
    {
        public void Create()
        {
            BoilWater();
            AddMainIngredientInCup();
            PourWaterInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
            Notify();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boil water.");
        }

        internal abstract void AddMainIngredientInCup();

        private void PourWaterInCup()
        {
            Console.WriteLine("Pour hot water into cup");
        }

        internal virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        internal abstract void AddCondiments();

        private void Notify()
        {
            Console.WriteLine("Hot drink is ready. Bon appetit!\r\n");
        }
    }
}
