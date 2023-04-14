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
            // Simple game to find out what day it is today just by picking a number 1-7

            // This will ask a question on the console
            Console.WriteLine("Pick a number 1-7 to find out what day it is.");
            int day = Convert.ToInt32(Console.ReadLine());
            bool guess = day == 5;
            do
            {
                switch (day)
                {   
                    // These are all the different cases the game has to go through,
                    // if the wrong number is picked, it will just ask you to pick another number 
                    // once number 5 is picked the game will be over
                    case 1:
                        Console.WriteLine("Today is not Monday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Today is not Tuesday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Today is not Wednesday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Today is not Thursday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Today is Friday! Yay!");
                        guess = true;
                        break;
                    case 6:
                        Console.WriteLine("Today is not Saturday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Today is not Sunday. Try again.");
                        Console.WriteLine("Pick a number 1-7 to find out what day it is.");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!guess);
            Console.Read();
        }
    }
}
