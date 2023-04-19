using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Created class Person
    public class Person
    {
        // Gave it two properties called FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method that takes no parameters and just prints full name to the console 
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
