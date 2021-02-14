using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class After2010CreditCalculator : CreditCalculator
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using after 2010");
        }
    }
}
