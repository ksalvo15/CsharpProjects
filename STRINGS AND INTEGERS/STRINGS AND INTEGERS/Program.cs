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

            int i;
            i = 0;

            Console.WriteLine("please write a non 0 number that we will use to divide the array of numbers that we have");

            int dividenum = int.Parse(Console.ReadLine());

            foreach (int divided in intList)
            {

            }




            //Run the code, entering in non - zero numbers as the user.Look at the displayed results.


                //Run the code again, entering in zero as the number to divide by.Note any error messages you get.


                //Run the code once again, entering in a string as the number to divide by.Note any error messages you get.


                //Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
        }
    }
}
