using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {   // Instantiating Employee object with Sample Student
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            // Calling SayName method on the object
            employee.SayName();
            Console.ReadLine();

        }
    }
}
