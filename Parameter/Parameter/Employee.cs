using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    // Generic parameter
    public class Employee <T>
    {
        // Added a property called things 
        public List<T> things { get; set; }
    }
}
