namespace Command.Domain
{
    class SandwichCommand : ICommand
    {
        Sandwich sandwich;
        public SandwichCommand()
        {
            sandwich = new Sandwich();
        }
        public void Execute()
        {
            sandwich.Make();
        }
    }
}
