using System;

namespace Datetime
{
    class Program
    {
        static void Main()
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please write a number");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = currentDateTime.AddHours(usernumber); //this adds the number that was entered in by the user to the current date time
            Console.WriteLine("you wrote {0}, it will be {1} in {0}hours", usernumber, futureTime);
        }
    }
}
