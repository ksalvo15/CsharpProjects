using System;

namespace testmath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the weight of your package?");
            string weight = Console.ReadLine();
            int numweight = Convert.ToInt32(weight);

            if (numweight > 50)
                { 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                }

            else
                {
                Console.WriteLine("What is the package height?");
                string height = Console.ReadLine();
                int packheight = Convert.ToInt32(height);

                Console.WriteLine("What is the package length?");
                string length = Console.ReadLine();
                int packlength = Convert.ToInt32(length);

                Console.WriteLine("What is the package width?");
                string width = Console.ReadLine();
                int packwidth = Convert.ToInt32(width);

                int TotalPrice = ((packwidth * packheight * packlength * numweight) / 100);
                string moneyprice = TotalPrice.ToString("C");

                Console.WriteLine("Your estimated total for shipping this package is: " + moneyprice);
                Console.ReadLine();
                }
            
            


        }
    }
}