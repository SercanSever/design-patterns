using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class CreditManagerProxy : CreditBase
    {
        CreditManager _creditManager;
        int _cachedValue;
        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }
            return _cachedValue;
        }
    }
}
