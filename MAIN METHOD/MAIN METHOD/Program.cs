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
            int intresult2 = submethod.Math(decnum);
            decimal result2 = Convert.ToDecimal(intresult2); //should i be using float?

            Console.WriteLine(decnum + " + 1 = " + result2);

            //Part3
            Console.WriteLine("What string do you want to use to do math operations?");
            try
            {
                
                int stringnumber = Convert.ToInt32(Console.ReadLine());

                int result3 = submethod.Math(stringnumber);

                Console.WriteLine(stringnumber + " converted to a number + 1 is = " + result3); //this seems to be multiplying it by 2?
            }

            catch (FormatException)
            {
                Console.WriteLine("the string entered could not be converted to an integer");
            }
            
        }
    }
}
