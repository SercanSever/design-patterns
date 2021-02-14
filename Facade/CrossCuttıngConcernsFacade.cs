using Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CrossCuttıngConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public CrossCuttıngConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
