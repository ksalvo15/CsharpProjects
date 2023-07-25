using System;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\kelse\Desktop\Logs\log.txt", true)) //this writes the user input to the text file
            {
                file.WriteLine(usernumber);
            }

            Console.WriteLine("here is what is in your file");
            using (StreamReader reader = new StreamReader(@"C:\Users\kelse\Desktop\Logs\log.txt", true)) //this reads the text file
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine(fileContent); //this writes the file content to the console
            }

        }
    }
}
