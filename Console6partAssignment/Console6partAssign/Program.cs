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

            bool guessed = true;
            int a;

            do
            {
                
                while (true)
                   
                {
                    Console.WriteLine("Pick an index from our List");
                    string guess = Console.ReadLine();
                    for (a = 0; a < newList.Count; a++)
                    {
                        if (!newList.Contains(guess))
                        {
                            Console.WriteLine("that item was not in the index please guess again");
                        }

                        else if (guess == newList[a])
                        {
                            Console.WriteLine("that item was found at index: " + a);
                                guessed = false;
                            break;
                        }
                    }
                }
                
            } while (guessed);




            List<string> sameString = new List<string>();
            sameString.Add("Apple");
            sameString.Add("Banana");
            sameString.Add("Grape");
            sameString.Add("Apple");

            Console.WriteLine("Pick an index from our Index");
            string sameguess = Console.ReadLine();
            int b;
            for (b = 0; b < sameString.Count; b++)
            {
                if (!sameString.Contains(sameguess))
                {
                    Console.WriteLine("that item was not in the index");
                }

                else if (sameguess == sameString[b])
                {
                    Console.WriteLine("that item was found at index: " + b);
                }
            }


            Console.ReadLine();

        }


            




        //foreach (string userAdd in stringList)
        //{
        // Console.WriteLine(userAdd); //this adds the userinput to the list                    

        //}







    }
}

