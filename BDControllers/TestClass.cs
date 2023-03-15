namespace MaSearcher.BDControllers
{
    internal class TestClass : IBDController, IFIOController, IEmailController, IPhoneController
    {
        void IFIOController.search(string arg)
        {
            Console.WriteLine("IFIOController.search");
        }

        void IEmailController.search(string arg)
        {
            Console.WriteLine("IEmailController.search");
        }

        void IPhoneController.search(string arg)
        {
            Console.WriteLine("IPhoneController.search");
        }

    }
}
