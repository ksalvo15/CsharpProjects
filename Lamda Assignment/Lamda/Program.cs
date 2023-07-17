using System;
using System.Collections.Generic;

namespace Lamda
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Alex", LastName = "Chan" },
            new Employee { Id = 5, FirstName = "Mike", LastName = "Lee" },
            new Employee { Id = 6, FirstName = "Joe", LastName = "Williams" },
            new Employee { Id = 7, FirstName = "Emily", LastName = "Clark" },
            new Employee { Id = 8, FirstName = "Jack", LastName = "White" },
            new Employee { Id = 9, FirstName = "Tim", LastName = "Davis" },
            new Employee { Id = 10, FirstName = "Jill", LastName = "Miller" }
            };

            List<Employee> joeList = employees.FindAll(emp => emp.FirstName == "Joe");

            //List<Employee> joelist = new List<Employee>();
            //foreach (Employee emp in employees)
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        joelist.Add(emp);
            //    }
            //}
            Console.WriteLine("Joe List");
            foreach (Employee joeemp in joeList)
            {
                Console.WriteLine($"Id: {joeemp.Id}, Name: {joeemp.FirstName} {joeemp.LastName}");
            }

            List<Employee> IDover5 = employees.FindAll(id => id.Id > 5);

            Console.WriteLine("Ids over 5 List");
            foreach (Employee idlist in IDover5)
            {
                Console.WriteLine($"Id: {idlist.Id}, Name: {idlist.FirstName} {idlist.LastName}");
            }

            Console.ReadLine();

        }
    }
}
