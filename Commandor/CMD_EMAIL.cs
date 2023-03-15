namespace MaSearcher.Commandor
{
    internal class CMD_EMAIL : ICommand
    {
        private string _email = "";
        private SearchController _searchController;
        public CMD_EMAIL(SearchController searchController, string email)
        {
            _email = email;
            _searchController = searchController;
        }
        public void Execute() 
        {
            Console.WriteLine($"is email: {_email}");
            _searchController.searchByEMAIL(_email);
        }
    }
}
