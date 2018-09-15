namespace Command.Domain
{
    class PizzaCommand : ICommand
    {
        Pizza pizza;
        public PizzaCommand()
        {
            pizza = new Pizza();
        }
        public void Execute()
        {
            pizza.Bake();
        }
    }
}
