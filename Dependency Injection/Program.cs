using Dependency_Injection.Interfaces;
using Ninject;
using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<ProductDal>().InSingletonScope();


            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());
            productManager.Save();
        }
    }
}
