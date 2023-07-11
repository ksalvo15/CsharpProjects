using System;

namespace Methods_and_Objects
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
