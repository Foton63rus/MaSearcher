namespace MaSearcher.Commandor
{
    internal class CMD_FIO : ICommand
    {
        private string _fio ="";
        private SearchController _searchController;
        public CMD_FIO(SearchController searchController, string fio)
        { 
            _fio = fio;
            _searchController = searchController;
        }
        public void Execute()
        {
            Console.WriteLine($"is FIO: {_fio}");
            _searchController.searchByFIO(_fio);
        }
    }
}
