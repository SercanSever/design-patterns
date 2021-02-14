using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Employee : Product Price Changed !");
        }
    }
}
