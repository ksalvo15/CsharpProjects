using System;
using System.Collections.Generic;

namespace Array_Assignment

{
    class Program
    {
        static void Main()
        {
            
            string[] stringArray = {"tim", "jon", "kelly", "austin", "beckie", "jenica", "ron"};
            Console.WriteLine("select an index of the string Array");
            int userstring = int.Parse(Console.ReadLine());
            if (userstring > 6)
            {
                Console.WriteLine("That index doesn't exist"); //will tell the user that the index selected doesn't
            }
            else
            {
                Console.WriteLine(stringArray[userstring]); //if user selects an index that exists it will display the array
            }

            int[] numArray = { 2, 4, 1, 6, 90, 25, 30 };
            Console.WriteLine("select an index of the integer Array");
            int inputarray = int.Parse(Console.ReadLine());
            if (inputarray > 6)
            {
                Console.WriteLine("That index doesn't exist"); //will tell the user that the index selected doesn't exist
            }
            else
            {
                Console.WriteLine(numArray[inputarray]); //if user selects an index that exists it will display the array
            }

            List<string> intList = new List<string>();
            intList.Add("Apple");
            intList.Add("Banana");
            intList.Add("Grape");
            intList.Add("Bread");

            Console.WriteLine("Pick an index from our List");
            int inputList = int.Parse(Console.ReadLine());
            if (inputList > 3)
            {
                Console.WriteLine("That index doesn't exist"); //will tell the user that the index selected doesn't
            }
            else
            {
                Console.WriteLine(intList[inputList]); //if user selects an index that exists it will display the array
            }
            Console.ReadLine();

            // 4 Create a list of strings








        }
    }
}
