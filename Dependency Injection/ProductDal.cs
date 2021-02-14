using Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class ProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Ef");
        }
    }
}
