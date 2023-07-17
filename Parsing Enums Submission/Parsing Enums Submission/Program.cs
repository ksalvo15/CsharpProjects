using System;

namespace Parsing_Enums_Submission
{
    class Program
    {
        public enum DayofWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday

        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a day of the week");
                string userday = Console.ReadLine();
                DayofWeek day = (DayofWeek)Enum.Parse(typeof(DayofWeek), userday);
                Console.WriteLine("you wrote a day of the week {0}", day);
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a string");
            }
        }        
    }
}
