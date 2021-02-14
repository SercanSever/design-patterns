using Adaptor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    public class SsLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged, {0}",message);
        }
    }
}
