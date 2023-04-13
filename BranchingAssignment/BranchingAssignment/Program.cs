using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple console-based application for getting a shipping quote for a package.

            // The name of the program will show up on the console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // This is asking user to enter the package weight
            Console.WriteLine("Enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            // If package weight is greater than 50, display this message and the program will end
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {   
                // If weight is less than 50, it will ask the user to input width, height, and length of the package
                Console.WriteLine("Enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());

                int packDimensions = packWidth + packHeight + packLength;

                // If package total dimensions are greater than 50, display this message and program will end
                if (packDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                // Calculates shipping cost
                else
                {
                    int packTotal = packWidth * packHeight * packLength;
                    int packDimWeight = packTotal * packWeight;
                    decimal shippingQuote = Convert.ToDecimal(packDimWeight) / 100m;

                    // This will display the shipping quote to the console
                    Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote.ToString() + "\nThank you!" );
                    Console.ReadLine();
                }

            }



        }
    }
}
