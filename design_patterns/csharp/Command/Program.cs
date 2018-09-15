using System;
using Command.Domain;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            WaiterInvoker waiter = new WaiterInvoker();
            waiter.Command = new PizzaCommand();
            waiter.BringFood();
            waiter.Command = new SandwichCommand();
            waiter.BringFood();
            waiter.Command = new SpaghettiCommand();
            waiter.BringFood();
        }
    }
}
