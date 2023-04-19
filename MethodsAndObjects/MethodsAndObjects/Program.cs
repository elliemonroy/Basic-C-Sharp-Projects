using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee class inherits from Person class allowing me to use Person's properties 
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
            // Calls the superclass method SayName on the employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
