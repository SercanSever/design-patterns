using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SpecialOffer : CarDecoratorBase
    {
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice * 90/100;
            }
            set 
            {

            }
        }
    }
}
