using Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class ProductManager
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Save()
        {
            //Bussiness Code..
            _productDal.Save();
        }
    }
}
