using System;


namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two objects of the Employee class and assigned values to their properties
            Employee employee = new Employee() { FirstName = "Bob", LastName = "Simmons", Id = 1111 };
            Employee employee1 = new Employee() { FirstName = "Carey", LastName = "Jones", Id = 1111 };

            // This will print their information to the console
            Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " " + employee1.Id);
            Console.ReadLine();

            // If employee.Id is == employee1.Id print this message to the console 
            if(employee == employee1)
            {
                Console.WriteLine("The Ids of the two employees match.");
            }
            // if not print this message to the console 
            else
            {
                Console.WriteLine("The Ids are unique.");
            }
        }
    }
}
