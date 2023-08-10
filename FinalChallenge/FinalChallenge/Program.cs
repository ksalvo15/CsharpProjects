using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Heloo enter a firstname for a new student");
                var fname = Console.ReadLine();


                Console.WriteLine("Heloo enter a lastname for a new student");
                var lname = Console.ReadLine();

                Console.WriteLine("Heloo enter a date of birth for a new student");
                var birth = Convert.ToDateTime(Console.ReadLine());

                var student = new Student { StudentFName = fname, StudentLName = lname, StudentDateofBirth = birth };
                db.Student.Add(student);
                db.SaveChanges();

                var query = from s in db.Student
                            orderby s.StudentLName
                            select s;
                Console.WriteLine("All the students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentLName + ", " + item.StudentFName);
                }

                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }
                


        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentFName { get; set; }
            public string StudentLName { get; set; }
            public DateTime? StudentDateofBirth { get; set; }

        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Student { get; set; }
        }
    }
}
