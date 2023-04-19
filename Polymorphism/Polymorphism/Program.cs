using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created new object Employee
            IQuittable quittable = new Employee();

            // Instantiating Employee object with Sample Student
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // Calling SayName method on the object
            employee.SayName();
            Console.ReadLine();
            // Calling Quit method on the object 
            quittable.Quit();
            
        }
    }
}
