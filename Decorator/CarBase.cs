using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }
}
