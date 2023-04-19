using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating class Integers
            Integers integers = new Integers();

            // Asking the user to enter a number
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling Integer method on the number entered 
            integers.Integer(num);

            // Calling Integer method with output parameters
            integers.Equals(out int numTwo);

            // Calling Plus method to work for both double and int making it an overloaded method
            int num2 = integers.Plus(4, 2);
            double num3 = integers.Plus(4.2, 2.5);
            Console.WriteLine("Int: " + num2 + "\nDouble: " + num3);
            Console.ReadLine();

            // Calling my static method from my static class 
            Stat.Stati();
            Console.ReadLine();
            

        }
    }
}
