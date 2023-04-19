using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Created abstract class Person
    public abstract class Person
    {
        // Gave it two properties 
        public string firstName { get; set; }
        public string lastName { get; set; }

        // This makes it so any class that inherits from Person can implement from it 
        public abstract void SayName();
    }
}
