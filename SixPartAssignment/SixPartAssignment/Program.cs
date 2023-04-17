using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One 
            // A one-dimesional array of strings
            string[] greetings = { "Hi ", "Hello ", "Bye ", "See ya " };

            // Ask user to input some text
            Console.WriteLine("What is your name?");
            string firstName = (Console.ReadLine());
            // First loop
            for (int i = 0; i < greetings.Length; i++)
            {
                greetings[i] = greetings[i] + firstName + ".";
            }
            // Second loop that prints off each string in the array
            for (int i = 0; i < greetings.Length; i++)
            {
                
                Console.WriteLine(greetings[i]);
            }
            Console.ReadLine();


            // Part Two 
            // Infinite loop when true
            bool trueOrFalse = true;
            while (trueOrFalse)
            {
                Console.WriteLine("The grass is red");
                // This will end the loop by changing it to false
                trueOrFalse = false;
                Console.ReadLine();
            }


            // Part Three
            // Comparison used "<" to iterate through the loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Print three times");
            }
            Console.ReadLine();
            //Comparison used "<=" to iterate through another loop
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Print two times");
            }
            Console.ReadLine();


            // Part Four
            // A list of strings 
            List<string> names = new List<string>() { "Ellie", "Drako", "Joe", "Erick" };
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            // Ask user to input text to search for in the list
            Console.WriteLine("Enter a name to find the index of that string");
            string name = Console.ReadLine();
            bool answer = false;

            // Loop that iterates through the list and then displays the index of the list item
            for (int e = 0; e < names.Count; e++)
            {
                if(names[e] == name)
                {
                    Console.WriteLine(name + " is found at index " + e);
                    answer = true;
                    // Stops the loop
                    break; 
                }
            }

            // If name is not on the list display this message
            if (!answer)
            {
                Console.WriteLine(name + " is not on the list.");
            }
            Console.ReadLine();


            // Part Five
            // A list of strings that has two identical strings 
            List<string> colors = new List<string>() { "pink", "purple", "green", "pink" };
            foreach (string i in colors)
            {
                Console.WriteLine(i);
            }

            // Ask user to input text to search for in the list
            Console.WriteLine("Enter a color to find the index of that string");
            string color = Console.ReadLine();
            bool option = false;

            // Loop that iterates through the list and then displays the index of the list item
            for (int c = 0; c < colors.Count; c++)
            {
                if (colors[c] == color)
                {
                    Console.WriteLine(color + " is found at index " + c);
                    option = true;
                }
            }

            // If name is not on the list display this message
            if (!option)
            {
                Console.WriteLine(color + " is not on the list.");
            }
            Console.ReadLine();


            // Part Six
            // A list of strings that has two identical strings 
            List<string> animals = new List<string>() { "dog", "cat", "lizard", "dog" };
            List<string> duplicates = new List<string>();

            // Loop that evaluates each item in the list and displays a message showing the string and whether or not it has already appeared in the list
            foreach (string animal in animals)
            {
                if (duplicates.Contains(animal))
                {
                    Console.WriteLine(animal + " this item is a duplicate.");
                }
                else
                {
                    Console.WriteLine(animal + " this item is unique.");
                    duplicates.Add(animal);
                }

            }
            Console.ReadLine();


















        }
    }
}
