using System;
using System.Collections.Generic;

namespace Console6partAssign
{
    class Program
    {
        static void Main()
        {

            List<string> stringList = new List<string>();

            int i;
            i = 0;

            int x = 2;

            while ((x += 2) < 10)
            {
                Console.WriteLine(x);

            }


            Console.WriteLine("please add an item to the index");
            string UserAdd = Console.ReadLine(); //reads the user input and puts it to sting form
            stringList.Add(UserAdd); //adds the user input to the list
            //i++;

            for (i = 0; i < stringList.Count; i++)
            {
                stringList[i] += UserAdd;
            }

            Console.WriteLine("Entered string count = {i}", stringList); //this writes the string list
            //foreach (string userAdd in stringList)
            //{
               // Console.WriteLine(userAdd); //this adds the userinput to the list                    

            //}

            
                



        }
    }
}

