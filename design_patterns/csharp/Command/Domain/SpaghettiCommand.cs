namespace Command.Domain
{
    class SpaghettiCommand : ICommand
    {
        Spaghetti spaghetti;
        public SpaghettiCommand()
        {
            spaghetti = new Spaghetti();
        }

        public void Execute()
        {
            spaghetti.Cook();
        }
    }
}
