using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    public class VoidMethod
    {       
        public void Math(int var1, out int result) //part 2 output parameters
        {
            //Part1
            result = var1 / 2;
            Console.WriteLine(var1 + " / 2 = " + result);
                
            Console.ReadLine();
        }

        //part 5 overloading the method
        public void Math(string var1)
        {
            //Part1
            string result = var1;
            Console.WriteLine(var1 + " strings cannot be divided by 2");

            Console.ReadLine();
        }

        public static void StaticM()
        {
            //Part6
            Console.WriteLine("static method?");

        }
    }
}
