using System.Text.RegularExpressions;

namespace MaSearcher.Commandor
{
    internal class Commandor
    {
        private SearchController _searchcontroller;
        public bool IsAlive = true;

        private Regex regMail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        private Regex regFIO = new Regex(@"^([\p{L}\p{M}]+(\s[\p{L}\p{M}]+){1,2})$");
        private Regex regPhone = new Regex(@"^(\+7|8|7|)?\s*\d{3}[-.\s]?\d{3}[-.\s]?\d{2}[-.\s]?\d{2}$");
        public ICommand RunCommand(string cmd)
        {
            if (cmd == "")
            {
                return new CMD_EMPTY();
            }

            if (cmd.ToLower().StartsWith("exit"))
            {
                return new CMD_EXIT(this);
            }

            if (regMail.IsMatch(cmd))
            {
                return new CMD_EMAIL(_searchcontroller, cmd);
            }

            if (regFIO.IsMatch(cmd))
            {
                return new CMD_FIO(_searchcontroller, cmd);
            }

            if (regPhone.IsMatch(cmd))
            {
                return new CMD_PHONE(_searchcontroller, cmd);
            }

            return new CMD_EMPTY();
        }
        public Commandor(SearchController controller)
        {
            _searchcontroller = controller;
        }
    }
}
