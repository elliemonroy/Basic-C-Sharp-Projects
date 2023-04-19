using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated Employee object with type string and assigned it a list of names
            Employee<string> name = new Employee<string>();
            name.things = new List<string> { "Ellie", "Joe", "Drako" };

            // Created a loop to display all the names on the list to the console
            foreach(string thing in name.things)
            {
                Console.WriteLine(thing);
            }

            // Instantiated Employee object with type int and assigned it a list of numbers
            Employee<int> number = new Employee<int>();
            number.things = new List<int> { 10, 24, 1993 };

            // Created a loop to display all the numbers on the list to the console
            foreach(int thing in number.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
