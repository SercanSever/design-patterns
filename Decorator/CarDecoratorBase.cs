using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CarDecoratorBase : CarBase
    {
        CarBase _carBase;
        public CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }
}
