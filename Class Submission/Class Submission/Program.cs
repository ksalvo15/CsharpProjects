using System;

namespace Class_Submission
{
    class Program
    {
        public static void Main(string[] args)
        {
            VoidMethod math = new VoidMethod();

            //part3
            Console.WriteLine("please add an integer");
            int result;
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            math.Math(num1, out result);

            //part 5
            Console.WriteLine("please add a string");
            string var2 = Console.ReadLine();
            math.Math(var2);

            //Part6
            VoidMethod.StaticM();

        }
    }
}
