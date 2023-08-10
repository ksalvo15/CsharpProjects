using System;

namespace METHOD_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //part1 and 2
            int var1 = 5;
            int var2 = 7;
            int result;
            mathmethod math = new mathmethod();

            result = math.Math(var1, var2);
            Console.WriteLine(var1 + " + " + var2 + " = " + result);


            //part 3 and 4
            Console.WriteLine("input one integer");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter another integer or press enter to skip");
            string maybe1 = Console.ReadLine();

            int input2 = 0; //if the value is null then input 2 is 0 
            if (!string.IsNullOrEmpty(maybe1)) //if the string maybe1 is not null them it turnsinto a string
            {
                input2 = Convert.ToInt32(maybe1);
            }
            

            result = math.Math(input1, input2);

            Console.WriteLine("the addition of the one or two numbers you put in is " + result);
        }
    }
}
