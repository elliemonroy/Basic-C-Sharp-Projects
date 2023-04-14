using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // This will ask the user to pick an index number to display a string on the console
        string[] stringArray = new string[] { "Bob", "Sam", "Ellie", "Drako", "Joe" };
        Console.WriteLine("What string from the array do you want to display? \nPick a number 0 through 4.");
        int stringIndex = Convert.ToInt32(Console.ReadLine());
 
       // If the index number is greater than 4, display this message 
       if (stringIndex > 4)
        {
            Console.WriteLine("Oops! That index does not exist!");
            Console.ReadLine();
        }

       // This will display the chosen string 
       else
        {
            Console.WriteLine("The string you chose is " + stringArray[stringIndex]);
            Console.ReadLine();
        }

       // This will ask the user to pick an index number to display a integer to the console
        int[] intArray = new int[] { 10, 24, 1993, 3, 400 };
        Console.WriteLine("What integer from the array do you want to display? \nPick a number 0 through 4.");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // If index number is less than 4, display this message
        if (intIndex > 4)
        {
            Console.WriteLine("Oops! That index does not exist!");
            Console.ReadLine();
        }

        // This will display the chosen integer
        else
        {
            Console.WriteLine("The integer you chose is " + intArray[intIndex]);
            Console.ReadLine();
        }

        // This will ask the user to pick an index number to display a string from the list to the console
        List<string> stringList = new List<string> {"red", "green", "yellow", "pink", "purple" };
        Console.WriteLine("What index from the list do you want to display? \nPick a number 0 through 4.");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // If index number is less than 4, display this message
        if (listIndex > 4)
        {
            Console.WriteLine("Oops! That index does not exist!");
            Console.ReadLine();
        }

        // This will display the chosen index from the list
        else
        {
            Console.WriteLine("The index from the list you chose is " + stringList[listIndex]);
            Console.ReadLine();
        }




    }
}

