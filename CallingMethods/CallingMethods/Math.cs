using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
    {
        // Method that takes user input and adds it to 300
        public int Add(int userValue)
        {
            int answer = userValue + 300;
            return answer;
        }
        // Method that takes user input and subtracts it by 11
        public int Subtract(int userValue)
        {
            int answer = userValue - 11;
            return answer;
        }
        // Method that takes user input and multiplies it by 10
        public int Multiply(int userValue)
        {
            int answer = userValue * 10;
            return answer;
        }
    }
}
