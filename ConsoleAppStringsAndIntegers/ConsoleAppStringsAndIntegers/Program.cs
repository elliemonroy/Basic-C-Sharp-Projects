using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
            // List of integers
            List<int> numbers = new List<int>() { 2, 5, 6, 7, 8 };
            try
            {
                // Ask user for a number to be divided by each number in the list 
                Console.WriteLine("Input a number to divide by: ");
                int number = Convert.ToInt32(Console.ReadLine());

                // Creats a loop for each of the item in the list
                foreach (int i in numbers)
                {
                    int divide = i / number;
                    Console.WriteLine(i + " divided by " + number + " equals " + divide);
                }
            }
            // This message will display on the console if user types a string instead of an integer
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            // This message will display on the console if user types in a zero 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // This message will display on the console if there are any other errors 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // This message will always display to the console
            finally
            {
                Console.WriteLine("This message has emerged from the try/catch block and continued on with program execution.");
                Console.ReadLine();
            }

        }

    }
    

