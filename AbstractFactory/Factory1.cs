using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Factory1 : CrossCuttıngConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}
