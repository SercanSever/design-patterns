using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nLogger !");
        }
    }
}
