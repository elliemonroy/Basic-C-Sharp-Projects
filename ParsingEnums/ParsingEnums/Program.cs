using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        // Created an enum for days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        static void Main(string[] args)
        {
            try
            {
                // Asks user to enter current day of the week
                Console.WriteLine("Please enter current day of the week:");
                string input = (Console.ReadLine());
                // Sets the value day to be used as the enum data type 
                DaysOfTheWeek day;
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                // This message will display to the console if user types in current day 
                Console.WriteLine("Today is " + day);
                Console.ReadLine();
            }
            catch (Exception)
            {
                // This message will display to the console if user does not type actual day
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }


        }
    }
}
