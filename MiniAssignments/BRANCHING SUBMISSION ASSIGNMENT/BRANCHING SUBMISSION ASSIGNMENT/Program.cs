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
            int numweight = Convert.ToInt32(weight); //converts the user input to a number

            if (numweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                Console.WriteLine("What is the package height?"); //if under 50 the program continues
                string height = Console.ReadLine();
                int packheight = Convert.ToInt32(height);

                Console.WriteLine("What is the package length?");
                string length = Console.ReadLine();
                int packlength = Convert.ToInt32(length);

                Console.WriteLine("What is the package width?");
                string width = Console.ReadLine();
                int packwidth = Convert.ToInt32(width);

                int packdimen = packheight + packlength + packwidth;

                if (packdimen > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express"); //if greater than 50 the program ends
                }

                else
                {
                    int TotalPrice = ((packwidth * packheight * packlength * numweight) / 100);
                    string moneyprice = TotalPrice.ToString("C");

                    Console.WriteLine("Your estimated total for shipping this package is: " + moneyprice);
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}