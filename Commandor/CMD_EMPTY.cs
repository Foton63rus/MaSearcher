using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSearcher.Commandor
{
    internal class CMD_EMPTY : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Попробуй еще раз");
        }
    }
}
