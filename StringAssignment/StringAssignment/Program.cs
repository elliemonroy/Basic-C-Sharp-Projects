using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Assigned firstName, lastName, and message to strings
            string firstName = "Bob";
            string lastName = " Ronalds, ";
            string message = "how are you doing?";

            // Converting string message to uppercase
            message = message.ToUpper();

            // Created a stringbuilder that builds a paragraph
            StringBuilder sb = new StringBuilder();
            sb.Append("Hi, my name is Ellie. ");
            sb.Append("I have a dog, his name is Drako. ");
            sb.Append("He likes to go on walks.");
           

            // Concatenating all three of my strings to print on the console
            Console.WriteLine(firstName + lastName + message);
            // This will print my stringbuilder on the console
            Console.WriteLine(sb);
            Console.ReadLine();

           
            
        }
    }
}
