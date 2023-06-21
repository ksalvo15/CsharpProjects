using System;
using System.Collections.Generic;

namespace Console6partAssign
{
    class Program
    {
        static void Main()
        {

            List<string> stringList = new List<string>();
            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Add("Grape");
            stringList.Add("Bread");

             
            Console.WriteLine("please add an item to the index");
            string inputList = Console.ReadLine(); //reads the user input and puts it to sting form
            stringList.Add(inputList); //adds the user input to the list

            Console.WriteLine("Entered string count = {0}", stringList.Count); //this writes the string list
            foreach (string userAdd in stringList)
            {
                Console.WriteLine(userAdd); //this adds the userinput to the list                    

            }
            Console.WriteLine("If you would like to continue adding to the array write another word, if you would like to exit type no");


            bool keeplooping = true;
            keeplooping = inputList != "no";

            while (keeplooping)
            {
                
                stringList.Add(inputList); //adds the user input to the list

                Console.WriteLine("Entered string count = {0}", stringList.Count); //this writes the string list
                foreach (string userAdd in stringList)
                {
                    Console.WriteLine(userAdd); //this adds the userinput to the list                    

                }
                Console.WriteLine("If you would like to continue adding to the array write another word, if you would like to exit type no");

                Console.ReadLine();


                if (inputList == "no")
                {
                    keeplooping = false;
                }
            }

        }
    }
}
