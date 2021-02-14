using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personelCar = new PersonelCar { Make = "BMW", Model = "3.20,", HirePrice = 2500 };
            var specialOffer = new SpecialOffer(personelCar);

            Console.WriteLine("Concrete {0}",personelCar.HirePrice);
            Console.WriteLine("Special Offer {0}",specialOffer.HirePrice);

            Console.ReadLine();

        }
    }
}
