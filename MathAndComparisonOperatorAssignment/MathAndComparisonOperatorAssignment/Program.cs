using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will print the program name to the console
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // This will ask Person 1 their hourly rate and hours worked 
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string hourlyRate = Console.ReadLine();
            int hRate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked = Console.ReadLine();
            int hWorked = Convert.ToInt32(hoursWorked);
            Console.ReadLine();

            // This will ask Person 2 their hourly rate and hours worked 
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hWorked2 = Convert.ToInt32(hoursWorked2);
            Console.ReadLine();

            // This will multiply Person 1 hours worked and hourly rate and then multiply that by 52 to print the annual salary to the console
            Console.WriteLine("Annual salary of Person 1:");
            Console.ReadLine();
            int annualSalary = hWorked * hRate;
            Console.WriteLine(annualSalary * 52);
            Console.ReadLine();

            // This will multiply Person 2 hours worked and hourly rate and then multiply that by 52 to print the annual salary to the console 
            Console.WriteLine("Annual salary of Person 2:");
            Console.ReadLine();
            int annualSalary2 = hWorked2 * hRate2;
            Console.WriteLine(annualSalary2 * 52);
            Console.ReadLine();

            // This will check if Person 1 or Person 2 makes more, then it will print true or false on the console 
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool trueOrFalse = annualSalary > annualSalary2;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();





        }
    }
}
