﻿using System;

namespace METHOD_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Voidclass math = new Voidclass();

            //part3
            Console.WriteLine("please add an integer");
            int input1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please add another integer");
            int input2 = Convert.ToInt32(Console.ReadLine());

            //part1 2 and 4
            math.Math(var1: input1, var2: input2); //this calls the method in the class with the parameters by name as var1= 5 and var 2 = 7

        }
    }
}
