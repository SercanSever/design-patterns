using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with Log4Net");
        }
    }
}
