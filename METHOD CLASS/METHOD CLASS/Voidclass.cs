using System;
using System.Collections.Generic;
using System.Text;

namespace METHOD_CLASS
{
    public class Voidclass
    {
        public void Math(int var1, int var2, int input1, int input2)
        {
            //Part1 and 2
            int result = var1 + 3;
            Console.WriteLine(var1 + " + 3 = " + result);
            Console.WriteLine("this number is just being displayed" + var2);

            Console.ReadLine();

            //Part3
            int result2 = input1 * input2;
            Console.WriteLine(input1 + " * " + input2 + " = " + result2);
        }
    }
}
