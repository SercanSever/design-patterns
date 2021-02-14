using System;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdaptor());
            productManager.Save();

            Console.ReadLine();
        }
    }
}
