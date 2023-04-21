using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    // Created my own exception 
    public class MyException : Exception
    {
        public MyException()
            : base() { }
        public MyException(string message)
            : base(message) { }
    }
}
