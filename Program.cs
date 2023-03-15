namespace MaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchController searchController = new SearchController();
            Commandor.Commandor _commandor = new Commandor.Commandor(searchController);
            while (_commandor.IsAlive)
            {
                Console.WriteLine($"Input:");

                _commandor.RunCommand(Console.ReadLine()).Execute();
            }
        }
    }
}