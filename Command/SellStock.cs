using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SellStock : IOrder
    {
        private StockManager _stockManager;
        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
