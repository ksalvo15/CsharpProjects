using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operators
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            bool same;
            same = emp1.Id == emp2.Id;
            return same;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            bool same;
            same = emp1.Id != emp2.Id;
            return same;
        }

        public void SayName()
        {
           string Fullname = (FirstName + " " + LastName);
           Console.WriteLine("Name:[" + Fullname + "]");
        }
    }
}
