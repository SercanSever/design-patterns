using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Atach(new CustomerObserver());
            productManager.Atach(new EmployeeObserver()); 
            productManager.UpdatePrice();
        }
    }
}
