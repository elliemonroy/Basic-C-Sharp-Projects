using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will print The Tech Academy. Student Daily Report. to the console
            Console.WriteLine("The Tech Academy. \nStudent Daily Report.");
            Console.ReadLine();

            // This will ask what is your name on the console
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // This will ask what course are you on the console
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // This will ask what page number on the console
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.ReadLine();

            // This will ask if you need help on the console
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string needHelp = Console.ReadLine();
            bool nHelp = Convert.ToBoolean(needHelp);
            Console.ReadLine();

            // This will ask if there are any positive experiences on the console
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string pExperiences = Console.ReadLine();

            // This will ask for any other feedback on the console
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeed = Console.ReadLine();

            // This will ask how mnay hours did you study on the console
            Console.WriteLine("How many hours did you study today?");
            string hoursStudying = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudying);
            Console.ReadLine();

            // This will print this message on the console
            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");
            Console.ReadLine();

        }

    }
}
