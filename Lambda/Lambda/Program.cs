using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of ten employees
            List<Employee> employeeList = new List<Employee>
            {
                new Employee {Id=1, FirstName="Bob", LastName="Jones"},
                new Employee {Id=2, FirstName="Joe", LastName="Lennard"},
                new Employee {Id=3, FirstName="Ken", LastName="Barbs"},
                new Employee {Id=4, FirstName="Sam", LastName="Richards"},
                new Employee {Id=5, FirstName="Kerry", LastName="Jons"},
                new Employee {Id=6, FirstName="Joe", LastName="Sand"},
                new Employee {Id=7, FirstName="Jake", LastName="Pawn"},
                new Employee {Id=8, FirstName="Zack", LastName="Build"},
                new Employee {Id=9, FirstName="Blaire", LastName="Fin"},
                new Employee {Id=10, FirstName="Carly", LastName="Jensen"},
            };

            // New list to add all Joes
            List<Employee> joes = new List<Employee>();

            // Loops through employee list to find all joes then displays it on the console 
            foreach (Employee name in employeeList)
            {
                if (name.FirstName == "Joe")
                {
                    joes.Add(name);
                }
            }
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.Id + " " + joe.FirstName + " " + joe.LastName);
            }
            Console.ReadLine();

            // Uses lambda function Where() to make a new list of employees with the fist name Joe and displays it to the console
            List<Employee> jLists = new List<Employee>();
            jLists = employeeList.Where(j => j.FirstName == "Joe").ToList();
            foreach(Employee j in jLists)
            {
                Console.WriteLine(j.Id + " " + j.FirstName + " " + j.LastName);
            }
            Console.ReadLine();

            // Uses lambda function Where() to make a new Id list that displays all employess with Id over 5 to the console 
            List<Employee> Ids = new List<Employee>();
            Ids = employeeList.Where(i => i.Id > 5).ToList();
            foreach(Employee i in Ids)
            {
                Console.WriteLine(i.Id + " " + i.FirstName + " " + i.LastName);
            }
            Console.ReadLine();
        }
    }
}
