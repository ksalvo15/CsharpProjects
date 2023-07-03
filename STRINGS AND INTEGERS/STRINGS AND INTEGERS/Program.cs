using System;
using System.Collections.Generic;

namespace STRINGS_AND_INTEGERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            List<int> intList = new List<int>();
            intList.Add(20);
            intList.Add(223);
            intList.Add(15);
            intList.Add(57);

            Console.WriteLine("please write a non 0 number that we will use to divide the array of numbers that we have");       

            try
            {
                int dividenum = int.Parse(Console.ReadLine());

                foreach (int divisor in intList)
                {
                    int divided = divisor / dividenum;
                    Console.WriteLine(divided);
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("you cannot divided by 0");
            }

            catch (FormatException)
            {
                Console.WriteLine("you tried to divide by a string");
            }

            Console.WriteLine("The program is done");
           
        }
    }
}
