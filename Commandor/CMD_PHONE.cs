namespace MaSearcher.Commandor
{
    internal class CMD_PHONE : ICommand
    {
        private string _phone = "";
        private SearchController _searchController;
        public CMD_PHONE(SearchController searchController, string phone)
        {
            _phone = phone;
            _searchController = searchController;    
        }
        public void Execute()
        {
            Console.WriteLine($"is phone: {_phone}");
            _searchController.searchByPHONE( _phone );
        }
    }
}
