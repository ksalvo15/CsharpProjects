using System;

namespace TryandCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentyear = DateTime.Now.Year;
            try
            {
                Console.WriteLine("what is your age?");
                int userage = Convert.ToInt32(Console.ReadLine());
                if (userage < 0)
                {
                    throw new Exception();
                }
                int userbirth = currentyear - userage;
                Console.WriteLine("you were born this year {0}", userbirth);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a positive integer without a decimal");
            }
            
        }
    }
}
