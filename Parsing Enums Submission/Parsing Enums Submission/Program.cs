using System;

namespace Parsing_Enums_Submission
{
    class Program
    {
        public enum DayofWeek
        {
            monday = 1,
            tuesday = 2,
            wednesday = 3,
            thursday = 4,
            friday = 5,
            saturday = 6,
            sunday = 7

        }
        public static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Please enter a day of the week");
                string userday = Console.ReadLine();
                DayofWeek day;
                //for (int i = 0; i < 7; i++)
                //{
                    if (Enum.TryParse(userday, true, out day))
                    {

                        Console.WriteLine("you wrote one of the days of the week {0}", day);
                    }
                    else
                    {
                        Console.WriteLine("Please enter an actual day of the week");
                    }
                //}                
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a string");
            }
        }        
    }
}
