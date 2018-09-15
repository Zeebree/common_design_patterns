namespace Command.Domain
{
    class WaiterInvoker
    {
        ICommand command;

        internal ICommand Command
        {
            get { return command; }

            set { command = value; }
        }

        public void BringFood()
        {
            Command.Execute();
        }
    }
}
