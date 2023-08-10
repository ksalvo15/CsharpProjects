using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Submission
{
    public class Class1
    {
        public Class1(string food)
        {
            constvar = food;
        }

        public Class1() : this("default food") //this takes the food variable and will change it to be default food if nesessary
        {

        }
        public string constvar { get; set; }
    }
}
