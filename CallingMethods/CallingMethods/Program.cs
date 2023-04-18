using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will ask user to input a number on the console
            Console.WriteLine("Enter a number you want to do a math operation on:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            // This calls the class Math containing three methods
            Math math = new Math();

            // This will print all three math problems and their answers to the console
            Console.WriteLine(userValue + " + 300 = " + math.Add(userValue));
            Console.ReadLine();

            Console.WriteLine(userValue + " - 11 = " + math.Subtract(userValue));
            Console.ReadLine();

            Console.WriteLine(userValue + " * 10 = " + math.Multiply(userValue));
            Console.ReadLine();

        }
    }
} 
