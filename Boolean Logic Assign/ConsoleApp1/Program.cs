using System;

namespace testmath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("car insurance");

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ofAge = Convert.ToInt32(age); //this converts the string to int
            bool oldenough = ofAge > 15;

            Console.WriteLine("Have you ever had a DUI true or false?");
            bool DUI; //needs to have this variable for the if statement
            bool noDUI = true; //this takes the if statment noDUI and makes it a bool statement
            DUI = Convert.ToBoolean(Console.ReadLine()); //this converts the input to a bool
            if (DUI == false)
            {
                noDUI = true;
            }

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticket = Convert.ToInt32(tickets); //this converts the string to int
            bool nottoomanytickets = ticket < 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(oldenough && noDUI && nottoomanytickets); //this takes the variables oldenough noDUI and toomanytickets and sees if they are all true and prints out if they are qualified
            Console.ReadLine();



        }
    }
}