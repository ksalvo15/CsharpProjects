using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    public class Program
    {
        const string Constvar = "apple";
        public string constvar;

        public Program(string constvar)
        {

            var Variable = "Beans";
            Console.WriteLine(Variable);
        }

        public Program() : this("default food")
        {
            
        }
    }        
}
