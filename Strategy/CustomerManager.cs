using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CustomerManager
    {
        public CreditCalculator CreditCalculator { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer Manager Bussiness Saved !");
            CreditCalculator.Calculate();
        }
    }
}
