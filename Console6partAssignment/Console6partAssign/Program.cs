using System;
using System.Collections.Generic;

namespace Console6partAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //part1
            List<string> stringList = new List<string>();
            stringList.Add("Stuff");
            stringList.Add("Something");
            int i;
            i = 0;

            Console.WriteLine("please append our array of stings with a string");
            string UserAdd = Console.ReadLine(); //reads the user input and puts it to sting form
            stringList[i] += UserAdd; //this adds what the user added to the end of all the strings

            for (i = 0; i < stringList.Count; i++)
            {                
                Console.WriteLine("Entered string count = {0} ", stringList[i]); //this writes the string list
            }


            //part2
            int x = 2;

            while ((x += 2) < 10)
            {
                Console.WriteLine(x); //this creates a loop that coninues by 2 until it is still less than 10
            }

            
            //part3
            Console.WriteLine("Choose a number between 1 and 5");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 4) //if the number they chose is greater or equal to 4
            {
                Console.WriteLine("you wrote {0}, a number bigger or equal to 4", num);
            }

            else if (num == 3) //number is = to 3
            {
                Console.WriteLine("you typed {0}", num);
            }

            else if (num < 3) //if anything else
            {
                Console.WriteLine("you typed {0}, a number smaller than 3", num);
            }


            //part4
            List<string> newList = new List<string>();
            newList.Add("Apple");
            newList.Add("Banana");
            newList.Add("Grape");
            newList.Add("Bread");

            int a;

            Console.WriteLine("type a fruit from our List");
            string guess = Console.ReadLine();
            for (a = 0; a < newList.Count; a++)
            {
                if (!newList.Contains(guess)) //if the guess was not in the array of stings already it will ask you to guess again
                {
                    Console.WriteLine("that item was not in the index please guess again");
                }

                else if (guess == newList[a]) //if the guess is contained in the list it will then produce it
                {
                    Console.WriteLine("that item was found at index: " + a);
                    break;
                }
            }


            //part5
            List<string> sameString = new List<string>();
            sameString.Add("Apple");
            sameString.Add("Banana");
            sameString.Add("Grape");
            sameString.Add("Apple");

            Console.WriteLine("type a fruit from our Index");
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


            //part6
            List<string> forString = new List<string>();
            forString.Add("mouse");
            forString.Add("cat");
            forString.Add("dog");
            forString.Add("mouse");

            List<string> duplist = new List<string>(); //a new list must be created

            foreach (string dup in forString)
            {                
            if (duplist.Contains(dup))
                        
                {
                    Console.WriteLine("That is a duplicate {0} ", dup);                        
                }
                else
                {
                    Console.WriteLine("That is unique {0} ", dup);
                    duplist.Add(dup);
                }
            }
            Console.ReadLine();
        }
    }
}


