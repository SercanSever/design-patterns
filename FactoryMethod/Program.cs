using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
        }
    }
    public interface ILogger
    {
        void Log();
    }
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new SsLogger();
        }
    }
    public class SsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with Ss Logger");
        }
    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved !");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
