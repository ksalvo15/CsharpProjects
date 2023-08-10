using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    public class Program
    {
        static void Main()
        {
            const string constvar = "apple";

            var newfooddict = new Dictionary<string, int>();

            Console.WriteLine(constvar);

            Class1 newClass = new Class1(constvar);
            Console.ReadLine();
        }
    }    
}
