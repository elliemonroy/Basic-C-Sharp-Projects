using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Operations
    {
        // This will take in an integer and return as an integer
        public int Operation(int answer)
        {
            return answer + 225;
        }
        // This will take in a decimal and return the answer as an integer
        public int Operation(decimal decimalNum)
        {
            int answer = Convert.ToInt32(decimalNum) * 12;
            return answer;
        }
        // This will take in a string and convert into an integer
        public int Operation(string number)
        {
            int answer = Convert.ToInt32(number) - 1;
            return answer;
        }
    }
}
