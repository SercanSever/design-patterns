using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Name = "Sercan Sever" };
            Employee employee2 = new Employee { Name = "Ahmet Sever" };

            employee1.AddSupOrdinates(employee2);

            Employee employee3 = new Employee { Name = "Eylem Günal" };

            employee1.AddSupOrdinates(employee3);
            employee2.AddSupOrdinates(employee3);

            Console.WriteLine(employee1.Name);
            foreach (Employee manager in employee1)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (Employee employee in manager)
                {
                    Console.WriteLine("     {0}",employee.Name);
                }
            }

            Console.ReadLine();

        }
    }
}
