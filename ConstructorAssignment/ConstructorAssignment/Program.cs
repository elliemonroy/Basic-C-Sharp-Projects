using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a const variable 
            const string color = "pink";

            // Created variable using the keyword var
            var sentence = "My favorite color is";
            // Printed full senence to the console 
            Console.WriteLine("Hi, my name is Ellie. {0} {1}.", sentence, color);

            // Created new person by chaining two constructors together 
            Person newPerson = new Person("Sam");

            Console.WriteLine(newPerson.Name +" is "+ newPerson.Age +" years old.");
            Console.ReadLine();

        }
    }
}
