using System;

namespace testmath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program”");
            string usernumber = Console.ReadLine();
            int usernumbers = Convert.ToInt32(usernumber); //this converts the string to int
            Console.WriteLine(usernumbers * 50);
            Console.ReadLine();
        }
    }
}
