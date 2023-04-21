using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for their age
            Console.WriteLine("Enter your age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                // If input is anything other than a whole number throw this exception
                if (age <= 0)
                {
                    throw new MyException();
                }
                // Gets current time and date
                DateTime currentTime = DateTime.Now;
                // Gets current year
                int currentYear = currentTime.Year;
                // Current year minus age will calculate birth year 
                int birthYear = currentYear - age;
                // This will display the users birth year to the console 
                Console.WriteLine("You were born in: " + birthYear);
                Console.ReadLine();
            }
            // Exceptions will pop up if user doesn't enter the correct information
            catch(MyException)
            {
                Console.WriteLine("Do not enter 0 or negative numbers, only whole numbers.");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("You typed something wrong.");
                Console.ReadLine();
            }
        }
    }
}
