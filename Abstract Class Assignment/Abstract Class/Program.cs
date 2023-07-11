using System;

namespace Abstract_Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            employee.FirstName = "sample";
            employee.LastName = "student";
            


            employee.SayName();
        }
    }
}
