using System;
using System.Collections.Generic;

namespace Console6partAssign
{
    class Program
    {
        static void Main()
        {
            int x = 2;

            while ((x += 2) < 10)
            {
                Console.WriteLine(x);

            }

            List<string> stringList = new List<string>();

            int i;
            i = 0;

            Console.WriteLine("please add an item to the array");
            string UserAdd = Console.ReadLine(); //reads the user input and puts it to sting form
            stringList.Add(UserAdd); //adds the user input to the list
            //i++;

            for (i = 0; i < stringList.Count; i++)
            {
                //stringList[i] += UserAdd;
                Console.WriteLine("Entered string count = {0} ", stringList[i]); //this writes the string list
            }

            Console.WriteLine("Choose a number between 1 and 5");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 4)
            {
                Console.WriteLine("you wrote {0}, a number bigger or equal to 4", num);
            }

            else if (num == 3)
            {
                Console.WriteLine("you typed {0}", num);
            }

            else
            {
                Console.WriteLine("you typed {0}, a number smaller than 3", num);
            }



            List<string> newList = new List<string>();
            newList.Add("Apple");
            newList.Add("Banana");
            newList.Add("Grape");
            newList.Add("Bread");

            Console.WriteLine("Pick an index from our List");
            string guess = Console.ReadLine();                    

            if (newList.Contains(guess))
            {
                int index = newList.FindIndex(a => a.Contains(guess));
                Console.WriteLine("that item was found at index: " + index);
            }
            else
            {
                Console.WriteLine("that item is not in the array");
            }                      



            List<string> sameString = new List<string>();
            newList.Add("Apple");
            newList.Add("Banana");
            newList.Add("Grape");
            newList.Add("Apple");

            Console.WriteLine("Pick an index from our List");
            string sameguess = Console.ReadLine();
            for (i = 0; i < stringList.Count; i++)

            if (newList.Count> 0)
                foreach (int index in sameString) ;
                    Console.WriteLine("that item was found at index: " + index);
            
            else
                Console.WriteLine("that item is not in the array");
            
            Console.ReadLine();
        }


            




        //foreach (string userAdd in stringList)
        //{
        // Console.WriteLine(userAdd); //this adds the userinput to the list                    

        //}







    }
}

