using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Employee Class is inherting from Person Class
    public class Employee : Person
    {
        // Implementing the SayName method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
