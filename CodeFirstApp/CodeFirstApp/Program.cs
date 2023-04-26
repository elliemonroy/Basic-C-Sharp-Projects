using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        public static object FiddleHelper { get; private set; }

        static void Main(string[] args)
        {
            // This will add new student Ken to the database
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Ken" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");
                Console.ReadLine();


     
            }
        }
    }
}
