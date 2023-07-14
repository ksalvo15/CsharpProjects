using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters

{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        public Employee(List<T> things)
        {
            Things = things;
        }
    }
       
}
