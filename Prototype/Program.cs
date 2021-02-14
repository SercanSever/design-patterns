using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Sercan";
            customer.LastName = "Sever";
            customer.City = "Bursa";
            customer.Id = 1;

            var customer2 = (Customer)customer.Clone();
            customer2.Name = "Ahmet";

            Console.WriteLine(customer.Name);
            Console.WriteLine(customer2.Name); //Örneğini kaybetmez. Aynı referans tutmazlar. Kaynağın ortak kullanımı.

            Console.ReadLine();
        }
    }
}
