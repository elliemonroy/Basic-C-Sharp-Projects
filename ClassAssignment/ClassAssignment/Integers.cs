using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Integers
    {
        // Created a void class that outputs an integer, this will divide the data by two
        public void Integer(int number)
        {
            int answer = number / 2;

            Console.WriteLine(number + " divided by 2 = " + answer);
            Console.ReadLine();
        }

        // Using an out allows numTwo to be called outside
        public void Equals(out int numTwo)
        {
            numTwo = 24;
            Console.WriteLine(numTwo + " This is using the out method.");
            Console.ReadLine();
        }

        // overloaded methods
        public int Plus(int x, int y)
        {
            return x + y;
        }

        public double Plus(double x, double y)
        {
            return x + y;
        }
    }

}
