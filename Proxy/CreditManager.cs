using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proxy
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 0; i < 10; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }
            return result
        }
    }
}
