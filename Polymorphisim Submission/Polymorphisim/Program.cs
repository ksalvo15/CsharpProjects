using System;

namespace Polymorphisim
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "sample";
            employee.LastName = "student";

            employee.SayName();
            
            IQuittable quittable = new Employee();
            quittable.Quit();                        
        }


    }
}
