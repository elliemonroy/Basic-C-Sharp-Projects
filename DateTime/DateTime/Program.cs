using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets the current date and time and displays it on the console 
            DateTime time = DateTime.Now;
            Console.WriteLine("Current date and time: " + time);
            // Ask user to enter a number 
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // This will take the number entered and add it to the current time, then display to the console 
            DateTime addTime = time.AddHours(num);
            Console.WriteLine(num + " hours from now will be " + addTime);
            Console.ReadLine();

        }
    }
}
