using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Customer : Product Price Changed !");
        }
    }
}
