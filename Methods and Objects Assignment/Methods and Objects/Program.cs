using System;

namespace Methods_and_Objects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee Fullname = new Employee
            {
                FirstName = "sample",
                LastName = "student"
            };


            Fullname.SayName();
        }
    }
}
