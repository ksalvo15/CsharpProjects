using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee<int> intemployee = new Employee<int>(new List<int> { 1, 2, 3, 4, 5, 6 }); //Instantiate int list

            Employee<string> stringemplyoee = new Employee<string>(new List<string> { "apple", "bannana", "grape" }); //Instantiate string list

            foreach (string things in stringemplyoee.Things) //loop for string
            {
                Console.WriteLine(things);
            }

            foreach (int things in intemployee.Things) //loop for int
            {
                Console.WriteLine(things);
            }
        }
    }
}
