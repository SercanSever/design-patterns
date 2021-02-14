using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CustomerManager
    {
        CrossCuttıngConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttıngConcernsFacade();
        }
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Logging.Log();
            _concerns.Authorize.CheckUser();
        }
    }
}
