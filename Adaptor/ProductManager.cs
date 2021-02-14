using Adaptor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    public class ProductManager
    {
        ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved !");
        }
    }
}
