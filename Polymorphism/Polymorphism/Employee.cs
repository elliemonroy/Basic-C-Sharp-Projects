using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Employee Class is inherting from Person Class and Interface Quittable
    public class Employee : Person, IQuittable
    {
        // Implementing the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        // Implementing the Quit() method inside of the Employee class
        public void Quit()
        {
            Console.WriteLine("Are you sure you would like to quit?");
            Console.ReadLine();
        }
    }
}
