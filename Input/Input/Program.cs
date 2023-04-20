using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a number 
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            // Adds the number entered into the text file 
            using (StreamWriter file = new StreamWriter(@"C:\Users\Ellie\Documents\doc.txt"))
            {
                file.WriteLine(num);
            }
            // Prints the text file back to the user 
            string text = File.ReadAllText(@"C:\Users\Ellie\Documents\doc.txt");
            {
                Console.WriteLine("This is your text file printing back to you: " + text);
            }
            Console.ReadLine();



        }
    }
}
