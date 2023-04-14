using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Continue while-loop until index is equal to 10
            int i = 0;
            while (i < 10)
            {
                // Display the index to the console
                Console.Write("While statement ");
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
