using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BuyStock : IOrder
    {
        private StockManager _stockManager;
        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Buy();
        }
    }
}
