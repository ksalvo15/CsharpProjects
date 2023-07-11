using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects
{
    public class Employee : Person
    {
        public int ID { get; set; }
    }
    public void Quit()
    {
        Console.WriteLine("They have quit");
    }
}
