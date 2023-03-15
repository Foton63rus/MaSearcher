using MaSearcher.BDControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSearcher
{
    internal class SearchController
    {
        public Action<string> SearchByFIOAction;
        public Action<string> SearchByEmailAction;
        public Action<string> SearchByPhoneAction;

        public void searchByFIO(string arg)
        {
            SearchByFIOAction?.Invoke(arg);
        }
        public void searchByEMAIL(string arg)
        {
            SearchByEmailAction?.Invoke(arg);
        }
        public void searchByPHONE(string arg)
        {
            SearchByPhoneAction?.Invoke(arg);
        }
        private void OnResponse(string arg)
        {

        }

        private void registrateBDController( BDControllers.IBDController bDController)
        {
            if (bDController is IFIOController)
            {
                SearchByFIOAction += (bDController as IFIOController).search;
            }
            if (bDController is IEmailController)
            {
                SearchByEmailAction += (bDController as IEmailController).search;
            }
            if (bDController is IPhoneController)
            {
                SearchByPhoneAction += (bDController as IPhoneController).search;
            }
        }

        public SearchController() 
        { 
            TestClass test = new TestClass();
            registrateBDController(test);
        }
    }
}
