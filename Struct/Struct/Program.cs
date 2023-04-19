using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        // Created a struct called number 
        public struct Number
        {
            // Gave it the property amount and made the data type be decimal 
            public decimal Amount; 
        }
        static void Main(string[] args)
        {
            // Created an object of data type Number and assigned an amount 
            Number number = new Number();
            number.Amount = 150.24m;

            // This will display the amount to the console 
            Console.WriteLine("This is the amount: " + number.Amount);
            Console.ReadLine();


        }
    }
}
