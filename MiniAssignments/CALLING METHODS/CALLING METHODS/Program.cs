using System;

namespace CALLING_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to use to do math operations?");

            int number = int.Parse(Console.ReadLine());

            int result1 = methods.AddOne(number);
            int result2 = methods.MinusbyTwo(number);
            int result3 = methods.MultiplyByTwo(number);

            Console.WriteLine(number + " + 1 = " + result1);
            Console.WriteLine(number + " - 2 = " + result2);
            Console.WriteLine(number + " * 2 = " + result3);





            //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

            //In the Main() program, ask the user what number they want to do the math operations on.

            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen.


        }
    }
} 
