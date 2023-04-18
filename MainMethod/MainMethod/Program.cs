using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calls the class Operations that contains the methods
            Operations operations = new Operations();

            // This calls my first method and passes an integer to the equation
            int answer = operations.Operation(30);
            Console.WriteLine("30 + 225 = " + answer);
            Console.ReadLine();

            // This calls my second method that takes in a decimal and returns an integer
            int answer2 = operations.Operation(22.2m);
            Console.WriteLine("22.2 * 12 = " + answer2);
            Console.ReadLine();

            // This calls my third method that takes in a string and returns an integer
            int answer3 = operations.Operation("5");
            Console.WriteLine("\"5\" - 1 = " + answer3);
            Console.ReadLine();

        }
    }
}
