using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string Fullname = (FirstName +" "+ LastName);
            Console.WriteLine("Name:[" + Fullname + "]");
        }
    }

    public class Employee : Person
    {
        public int ID { get; set; }        
        
    }
}
