using System;

namespace STRUCT_ASSIGNMENT
{

    public struct Number
    {
        public decimal Amount { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Number myNumber = new Number();

            myNumber.Amount = 154.52m;

        Console.WriteLine("here is the amount {0}", myNumber.Amount);
        }
    }
}
