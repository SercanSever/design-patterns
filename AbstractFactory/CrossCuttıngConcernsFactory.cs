using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class CrossCuttıngConcernsFactory
    {
        public abstract Logging CreateLogger();
    }
}
