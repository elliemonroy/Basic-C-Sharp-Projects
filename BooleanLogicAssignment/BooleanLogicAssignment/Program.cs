using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This simple program asks the user some questions and determines if they
            // qualify for car insurance 

            // This will ask the user how old they are
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
           
            // This will ask the user if they've ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Please answer \"True\" or \"False\")");
            bool duiAnswer = Convert.ToBoolean(Console.ReadLine());

            // This will ask the user how many speeding tickets they have 
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine());

            // This will calculate if they qualify for car insurance 
            bool insQual = age > 15 && duiAnswer == false && speedTicket <= 3;
            Console.WriteLine("Qualified? \n" + insQual.ToString());
            Console.ReadLine();
        }
    }
}
