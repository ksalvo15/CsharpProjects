using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisim
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public void Quit()
        {
            Console.WriteLine("They have quit");
        }
    }

    
}
