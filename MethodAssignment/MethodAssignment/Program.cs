using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This calls the class Math that contains the method
            Math math = new Math();

            // This will ask user to enter a number 
            Console.WriteLine("Please enter a number:");
            int numOne = Convert.ToInt32(Console.Read());

            // This will ask user to enter a second number or leave blank 
            Console.WriteLine("Please enter a second number (This is optional, press enter to leave blank):");
            string strNum = Console.ReadLine();
            

            // If the second number is left blank, do this 
            if (strNum == "")
            {
                Console.WriteLine(numOne + " + 12 = " + math.Integer(numOne));
                Console.ReadLine();
            }
            // If there are two numbers entered, do this 
            else
            {
                int numTwo = Convert.ToInt32(strNum);
                Console.WriteLine(numOne + " + " + numTwo + " = " + math.Integer(numOne, numTwo));
                Console.ReadLine();
            }
        }
    }
}
