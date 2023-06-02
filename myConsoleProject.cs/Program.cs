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
            string name = "kelsey";
            Console.WriteLine(name); //asking for a string variable called name
            Console.WriteLine("What course are you on");
            string course = "C# and .NET";
            Console.WriteLine(course);  //asking for a string variable called course
            Console.WriteLine("What page number");
            int pagenumber = 163;
            Console.WriteLine(pagenumber); //asking for a int variable called pagenumber
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needhelp = false;
            Console.WriteLine(needhelp); //asking for a boolean variable called needhelp
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = "still learning things!";
            Console.WriteLine(experiences); //asking for a string variable called experiences
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = "not at the moment";
            Console.WriteLine(feedback); //asking for a string variable called feedback
            Console.WriteLine("How many hours did you study today?");
            int hours = 2;
            Console.WriteLine(hours); //asking for a int variable called hours
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
