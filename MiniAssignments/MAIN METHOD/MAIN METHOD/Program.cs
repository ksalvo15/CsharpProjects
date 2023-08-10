using System;

namespace MAIN_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1
            Console.WriteLine("What integer do you want to use to do math operations?");
            int intnum = int.Parse(Console.ReadLine());

            int result1 = submethod.Math(intnum);

            Console.WriteLine(intnum + " * 2 = " + result1);


            //Part 2
            Console.WriteLine("What decimal do you want to use to do math operations?");
            decimal decnum = Convert.ToDecimal(Console.ReadLine());            
            decimal result2 = submethod.Math(decnum);

            Console.WriteLine(decnum + " + 1 = " + result2);


            //Part3
            Console.WriteLine("What string do you want to use to do math operations?");
            try
            {                
                string stringnumber = Console.ReadLine();

                int result3 = submethod.Math(stringnumber);

                Console.WriteLine(stringnumber + " converted to a number + 1 is = " + result3);
            }
            catch (FormatException)
            {
                Console.WriteLine("the string entered could not be converted to an integer");
            }
            
        }
    }
}
