using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your Name");
            Console.ReadLine();
            Console.WriteLine("What course are you on");
            Console.ReadLine();
            Console.WriteLine("What page number");
            
            string pagenumber = Console.ReadLine();
            int pagenumbers = Convert.ToInt32(pagenumber); //this converts the string to int
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            Convert.ToBoolean(Console.ReadLine());  //this converts the answer of false or true to an answer in ReadLine
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            
            string hours = Console.ReadLine();
            int hour = Convert.ToInt32(hours);  //this converts the string to int
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
