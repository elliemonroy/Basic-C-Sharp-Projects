using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // This will take whatever number user puts in, multiply it by 50 and print the result on the console
            Console.Write("Input the first number that will be multiplied by 50: ");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            int result = num2 * 50;
            Console.WriteLine(result);
            Console.ReadLine();

            // This will take whatever number user puts in, add it to 25 and print the total on the console
            Console.Write("Input the first number that will be added to 25: ");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);
            int total = num4 + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            // This will take whatever number user puts in, divide it by 12.5 and print the quotient on the console
            Console.Write("Input the first number that will be divided by 12.5: ");
            string num5 = Console.ReadLine();
            int num6 = Convert.ToInt32(num5);
            decimal quotient = num6 / 12.5m;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // This will take whatever number user puts in, check if it's greater than 50, print true or false on the console
            Console.Write("Input the first number to check if it's greater than 50: ");
            string num7 = Console.ReadLine();
            int num8 = Convert.ToInt32(num7);
            bool trueOrFalse = num8 > 50;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            // This will take whatever number user puts in, divide it by 7, print the remainder on the console
            Console.Write("Input the first number that will by divided by 7 to figure out the remainder: ");
            string num9 = Console.ReadLine();
            int num10 = Convert.ToInt32(num9);
            int answer = num10 / 7;
            int remainder = num10 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }

    }
}
