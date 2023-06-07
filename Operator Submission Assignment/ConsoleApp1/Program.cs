using System;

namespace testmath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1 input hourly rate");
            string Person1Hourly = Console.ReadLine();
            int Person1Hourlys = Convert.ToInt32(Person1Hourly); //this converts the string to int
            
            Console.WriteLine("Person 1 input hours worked");
            string Person1Hourworked = Console.ReadLine();
            int Person1Hoursworked = Convert.ToInt32(Person1Hourworked); //this converts the string to int
            
            Console.WriteLine("Person 2 input hourly rate");
            string Person2Hourly = Console.ReadLine();
            int Person2Hourlys = Convert.ToInt32(Person2Hourly); //this converts the string to int
            
            Console.WriteLine("Person 2 input hours worked");
            string Person2Hourworked = Console.ReadLine();
            int Person2Hoursworked = Convert.ToInt32(Person2Hourworked); //this converts the string to int
            
            Console.WriteLine("Annual salary of Person 1:");
            int Person1Annual = Person1Hoursworked * Person1Hourlys;
            Console.WriteLine((Person1Hoursworked * Person1Hourlys * 52).ToString("C")); //converts the salary to money vs int
           
            Console.WriteLine("Annual salary of Person 2:");
            int Person2Annual = Person2Hoursworked * Person2Hourlys;
            Console.WriteLine((Person2Hoursworked * Person2Hourlys * 52).ToString("C")); //converts the salary to money vs int
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool Person1Greater = Person1Annual > Person2Annual;
            Console.WriteLine(Person1Greater);
            Console.ReadLine();
        }
    }
}
