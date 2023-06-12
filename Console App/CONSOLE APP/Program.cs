using System;

namespace CONSOLE_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a color");
            string color = Console.ReadLine();
            bool picked = false;

            do //making sure the while loop hits
            {
                switch (color)
                {
                    case "pink":
                        Console.WriteLine("you picked " + color + ", fun fact about " + color + ", the pink power rangers name is Kimberly");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;

                    case "blue":
                        Console.WriteLine("you picked " + color + ", fun fact about " + color + " The ocean is blue because water absorbs colors in the red part of the light spectrum");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;

                    case "green":
                        Console.WriteLine("you picked " + color + ", fun fact about " + color + " green is the best color for photosynthesis for plants");
                        picked = true;
                        Console.WriteLine("thats also my favorite color!");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;

                    case "purple":
                        Console.WriteLine("you picked " + color + ", fun fact about " + color + " Carrots used to be purple, now most are orange!");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;

                    case "red":
                        Console.WriteLine("you picked " + color + ", fun fact about " + color + " Red is the first color babies can see after black and white");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;

                    default: //this will let any other entry pick this default
                        Console.WriteLine("you picked a color that I don't have a fun fact about");
                        Console.WriteLine("pick another color");
                        color = Console.ReadLine();
                        break;
                }
            }

            while (!picked); //this will trigger one the special color is picked

            Console.ReadLine();
        }
    }
}
