namespace MaSearcher.Commandor
{
    internal class CMD_EXIT : ICommand
    {
        private Commandor _cmdr;

        public CMD_EXIT(Commandor cmdr)
        {
            _cmdr = cmdr;
        }
        public void Execute()
        {
            Console.WriteLine("Application will be close.");
            _cmdr.IsAlive = false;
        }
    }
}
