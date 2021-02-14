using Adaptor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    public class Log4NetAdaptor : ILogger
    {
        //Adaptor
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }
}
