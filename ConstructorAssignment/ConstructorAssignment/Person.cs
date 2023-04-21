using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        // Created second constructor that inherits from first one and takes in one parameter
        public Person(string name) : this(name, 28)
        {

        }
        // Created first constructor  
        public Person(string name, int howOld)
        {
            Name = name;
            Age = howOld;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
