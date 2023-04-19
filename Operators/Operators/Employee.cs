using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // Created class Employee
    public class Employee

    {
        // Gave it three properties Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // This will check if employee1 Id is equal to employee2 Id
        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // This will check if employee1.Id is not equal to employee2.Id
        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
