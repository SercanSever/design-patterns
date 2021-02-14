using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCalculator = new After2010CreditCalculator();
            customerManager.SaveCredit();


            Console.ReadLine();
        }
    }
}
