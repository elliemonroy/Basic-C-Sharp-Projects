using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class Problems
            Problems problems = new Problems();
            // Calling Problem method and passing in two numbers
            problems.Problem(10, 24);
            // Calling Problem method, specifying the parameters by name and giving them values
            problems.Problem(first: 2, second: 1);

            Console.ReadLine();
        }
    }
}
