using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
        }
    }
    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockOpject = new object();
        private CustomerManager()
        {

        }
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockOpject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }
    }
}
