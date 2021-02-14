using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    public class Log4Net //nuget
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with log4net, {0}",message); 
        }
    }
}
