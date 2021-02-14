using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Before2010CreditCalculator : CreditCalculator
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using before 2010");
        }
    }
}
