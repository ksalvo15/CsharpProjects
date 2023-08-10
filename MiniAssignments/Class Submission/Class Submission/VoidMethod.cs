using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    public class VoidMethod
    {
        public void Math(int var1) //part 1 
        {
            //Part1
            
            int result = var1 / 2;
            Console.WriteLine(var1 + " / 2 = " + result);
        }

        public void Math(int var2, out int result) //part 2 output parameters
        {
            //Part1
            result = var2 / 2;
            Console.WriteLine(var2 + " / 2 = " + result);
        }

        //part 5 overloading the method
        public void Math(string var1)
        {
            //Part1
            string result = var1;
            Console.WriteLine(var1 + " strings cannot be divided by 2");

            Console.ReadLine();
        }

        public static class Staticclass
        {
            public static void StaticMath()
            {
                Console.WriteLine("this is a static class");
            }

        }

    }

    
}
